using InvokeApp.MAUI.ViewModels;

namespace InvokeApp.MAUI.Views;

public partial class RegisterPage : ContentPage
{
	public RegisterPage(RegisterViewModel registerViewModel)
	{
        BindingContext = registerViewModel;

        InitializeComponent();
	}
}