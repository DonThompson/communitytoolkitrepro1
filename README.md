# communitytoolkitrepro1

This repository attempts to reproduce the problems in the CommunityToolkit.MAUI project outlined in the following discussion:  https://github.com/CommunityToolkit/Maui/discussions/546


## Issue

The issue appears to be that when an object that was created as a subclass of another object is passed through the navigation dictionary, (a) `[QueryProperty]` causes an outright crash of the application, and (b) using `IQueryAttributable` to manually copy the parameter does not invoke `OnPropertyChanged` automatically.


## Current State

The committed code is in the "not working" state.  Launch the application and see two names in the MainPage list.  Tap any name to move to a detail page, passing the `Character` object to the DetailPage.  Note that no name is displayed in the DetailPage UI.

## Tests

1)  Comment IN the `OnPropertyChanged` line in `DetailViewModel.cs` to see the name start loading in the DetailPage UI.  [This is annotated as REPRO (3)].

2)  Remove the `IQueryAttributable` interface, then comment in the `[QueryProperty]` on the `DetailViewModel`.  Run the application, tap on a name, and note that the entire application will crash.  [This is annoted as REPRO (1)].

3)  Go to `MainViewModel.cs` and change the instances of `SubCharacter` back to the parent class `Character` when being new'd up in the constructor.  Make sure your `[QueryProperty]` is still commented IN on the `DetailViewModel`.  Run the application and everything will work as expected, and the name will display on the DetailPage.
