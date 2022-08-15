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
        c.Name = "Don";
        characters.Add(c);
        Character c2 = new Character();
        c2.Name = "Shaun";
        characters.Add(c2);
    }

    [RelayCommand]
    private async Task Tap(Character c)
    {
        try
        {
            // Currently "Shaun" will work but "Don" will fail due to invalid cast.

            await Shell.Current.GoToAsync(nameof(DetailPage), true, new Dictionary<string, object>()
            {
                { "character", c }
            });
        }
        catch (Exception ex)
        {

        }
    }
}
