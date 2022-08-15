namespace communitytoolkitrepro1;

public partial class PrimitiveDetailPage : ContentPage
{
	public PrimitiveDetailPage(PrimitiveDetailViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}