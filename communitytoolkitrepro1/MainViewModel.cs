using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace communitytoolkitrepro1;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    ObservableCollection<Character> characters;

    public MainViewModel()
    {
        characters = new ObservableCollection<Character>();

        //For repro, just load a few manually
        SubCharacter c = new SubCharacter();
        c.Name = "PrimitiveData";
        characters.Add(c);
        SubCharacter c2 = new SubCharacter();
        c2.Name = "ComplexData";
        characters.Add(c2);
    }

    [RelayCommand]
    private async Task Tap(Character c)
    {
        if (c.Name == "PrimitiveData")
        {
            // This approach requires the [QueryProperty] usage in the recipient
            await Shell.Current.GoToAsync($"{nameof(PrimitiveDetailPage)}?name={c.Name}");
        }
        else
        {
            // This approach required the IQueryAttributable implementation in the recipient
            await Shell.Current.GoToAsync(nameof(ComplexDetailPage), true, new Dictionary<string, object>()
            {
                { "character", c }
            });
        }
    }
}
