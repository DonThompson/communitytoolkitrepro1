using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace communitytoolkitrepro1;



//REPRO (1)  Ideal implementation is to just use the QueryProperty syntax.  However, when the "character" value is 
//  'new'd up' as a sub-class of Character, this will cause the application to crash outright.
//
//[QueryProperty("Character", "character")]
public partial class DetailViewModel : ObservableObject, IQueryAttributable
{
    [ObservableProperty]
    Character character;

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        //REPRO (2)  Secondary implementation is to manually handle the query property out of the dictionary.  I'm not sure what
        //  the above [QueryProperty] syntax does differently to cause a crash, but this line of code works fine.
        //HOWEVER, the UI does not update when this code is called, even though the query parameter is a fully working and normal
        //  object.
        character = query["character"] as Character;

        //REPRO (3)  Tertiary implementation is to manually call OnPropertyChanged after we set the object above.  Shouldn't this
        //  be unnecessary since character is already an [ObservableProperty]?
        //OnPropertyChanged("Character");
    }

    [RelayCommand]
    async Task GoBack()
    {
        await Shell.Current.GoToAsync("..");
    }
}
