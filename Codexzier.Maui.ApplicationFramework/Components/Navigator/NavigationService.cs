namespace Codexzier.Maui.ApplicationFramework.Components.Navigator;

public class NavigationService : INavigationService
{
    public void NavigateTo<TView>() where TView : ContentView
    {
        throw new NotImplementedException();
    }
}

public interface INavigationService
{
    void NavigateTo<TView>() where TView : ContentView;
}