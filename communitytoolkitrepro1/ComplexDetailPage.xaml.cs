namespace communitytoolkitrepro1;

public partial class ComplexDetailPage : ContentPage
{
	public ComplexDetailPage(ComplexDetailViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}