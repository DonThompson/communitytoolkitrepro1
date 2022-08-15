using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace communitytoolkitrepro1;
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
