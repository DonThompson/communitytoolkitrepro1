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
        Character c = new Character();
        c.Name = "Don";
        characters.Add(c);
        Character c2 = new Character();
        c2.Name = "Shaun";
        characters.Add(c2);
    }

    [RelayCommand]
    private async Task Tap(Character c)
    {
        //await Shell.Current.GoToAsync(nameof(CharDetailPage), true, new Dictionary<string, object>()
        //{
        //    { "character", c }
        //});
    }
}
