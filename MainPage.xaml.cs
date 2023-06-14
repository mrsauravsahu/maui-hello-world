using maui_hello_world.ViewModels;

namespace maui_hello_world;

public partial class MainPage : ContentPage
{
	public MainPage(CountViewModel countViewModel)
	{
		InitializeComponent();
    this.BindingContext = countViewModel;
  }
}

