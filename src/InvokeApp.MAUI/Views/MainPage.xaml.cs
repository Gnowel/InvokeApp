using InvokeApp.MAUI.ViewModels;

namespace InvokeApp.MAUI.Views;

public partial class MainPage : ContentPage
{
    public MainPage(MainViewModel mainViewModel)
    {
        BindingContext = mainViewModel;

        InitializeComponent();
    }
}
