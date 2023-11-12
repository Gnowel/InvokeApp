using InvokeApp.MAUI.Services.Navigation;
using InvokeApp.MAUI.Views;

namespace InvokeApp.MAUI;

public partial class AppShell : Shell
{
    private readonly  INavigationService _navigationService;
    public AppShell(INavigationService navigationService)
    {
        _navigationService = navigationService;

        InitializeRouting();
        InitializeComponent();
    }

    //protected override async void OnParentSet()
    //{
    //    base.OnParentSet();

    //    if (Parent is not null)
    //    {
    //        await _navigationService.InitializeAsync();
    //    }
    //}

    private static void InitializeRouting()
    {
        Routing.RegisterRoute("Login", typeof(LoginPage));
        Routing.RegisterRoute("Register", typeof(RegisterPage));
        Routing.RegisterRoute("Home", typeof(HomePage));
    }
}
