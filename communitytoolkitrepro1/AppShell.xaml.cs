namespace communitytoolkitrepro1;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(ComplexDetailPage), typeof(ComplexDetailPage));
        Routing.RegisterRoute(nameof(PrimitiveDetailPage), typeof(PrimitiveDetailPage));
    }
}
