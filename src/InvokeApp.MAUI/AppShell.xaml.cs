using InvokeApp.MAUI.Services.Navigation;
using InvokeApp.MAUI.Views;
using InvokeApp.MAUI.Views.Announcements;

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
        Routing.RegisterRoute("ProductDetail", typeof(ProductDetailPage));
        Routing.RegisterRoute("DescriptionProduct", typeof(DescriptionProductPage));
        Routing.RegisterRoute("SpecifyPrice", typeof(SpecifyPricePage));
        Routing.RegisterRoute("SelectLocation", typeof(SelectLocationPage));
    }
}
