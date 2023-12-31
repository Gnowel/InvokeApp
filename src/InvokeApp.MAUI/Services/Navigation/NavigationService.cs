﻿
namespace InvokeApp.MAUI.Services.Navigation
{
    public class NavigationService : INavigationService
    {
        public Task InitializeAsync()
        {
            throw new NotImplementedException();
        }

        public Task NavigateToAsync(string route, IDictionary<string, object> routeParameters = null)
        {
            var shellNavigation = new ShellNavigationState(route);

            return routeParameters is not null
                ? Shell.Current.GoToAsync(shellNavigation, routeParameters)
                : Shell.Current.GoToAsync(shellNavigation);
        }

        public Task PopAsync() => Shell.Current.GoToAsync("..");
    }
}
