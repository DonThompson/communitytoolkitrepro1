using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace communitytoolkitrepro1;

public partial class ComplexDetailViewModel : ObservableObject, IQueryAttributable
{
    [ObservableProperty]
    Character character;

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        // You want to be setting the property (Character) and not the field (character).
        Character = query["character"] as Character;
    }

    [RelayCommand]
    async Task GoBack()
    {
        await Shell.Current.GoToAsync("..");
    }
}
