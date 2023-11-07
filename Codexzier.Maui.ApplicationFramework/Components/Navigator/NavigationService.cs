using System.Runtime.CompilerServices;

namespace Codexzier.Maui.ApplicationFramework.Components.Navigator;

public class NavigationService : INavigationService
{
    private static NavigationService _instance;
    
    private ContentPresenter _menuContentPresenter;
    private ContentPresenter _mainContentPresenter;

    private NavigationService()
    {   
    }

    public static NavigationService GetInstance() => _instance ??= new NavigationService();

    public void LoadMenu<TView>() where TView : ContentView
    {
        this._menuContentPresenter.Content = Activator.CreateInstance<TView>().Content;
    }

    public void NavigateTo<TView>() where TView : ContentView
    {
        this._mainContentPresenter.Content = Activator.CreateInstance<TView>().Content;
    }

    public void SetMenuContent(ContentPresenter cp) => this._menuContentPresenter = cp;

    public void SetMainContent(ContentPresenter cp) => this._mainContentPresenter = cp;

   
}

public interface INavigationService
{
    void LoadMenu<TView>() where TView : ContentView;
    void NavigateTo<TView>() where TView : ContentView;
    
}