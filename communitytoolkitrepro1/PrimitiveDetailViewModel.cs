using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace communitytoolkitrepro1;


// QueryProperty only supports primitive data types as stated at: https://docs.microsoft.com/dotnet/maui/fundamentals/shell/navigation#pass-data
// meaning you can only pass strings, or ids, etc.
// Think of the QueryProperty as identifying a parameter in the query string which we have set as page?name=...
[QueryProperty("CharacterName", "name")]
public partial class PrimitiveDetailViewModel : ObservableObject
{
    [ObservableProperty]
    string characterName;

    [RelayCommand]
    async Task GoBack()
    {
        await Shell.Current.GoToAsync("..");
    }
}
