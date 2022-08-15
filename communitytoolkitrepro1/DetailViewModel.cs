using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace communitytoolkitrepro1;

[QueryProperty("Character", "character")]
public partial class DetailViewModel : ObservableObject
{
    [ObservableProperty]
    Character character;

    [RelayCommand]
    async Task GoBack()
    {
        await Shell.Current.GoToAsync("..");
    }
}
