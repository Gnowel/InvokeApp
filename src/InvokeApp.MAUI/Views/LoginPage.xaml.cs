using InvokeApp.MAUI.ViewModels;

namespace InvokeApp.MAUI.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage(LoginViewModel loginViewModel)
	{
        BindingContext = loginViewModel;

        InitializeComponent();
	}
}