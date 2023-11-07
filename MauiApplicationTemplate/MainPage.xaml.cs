using Codexzier.Maui.ApplicationFramework.Components.Navigator;
using MauiApplicationTemplate.Views.Conntent1;
using MauiApplicationTemplate.Views.Menu;

namespace MauiApplicationTemplate;

public partial class MainPage : ContentPage
{
    private MainPageViewModel _viewModel;
    
    public MainPage()
    {
        this.InitializeComponent();
        
        this._viewModel = (MainPageViewModel)this.BindingContext;
        
        var nav = NavigationService.GetInstance();
        
        nav.SetMenuContent(this.MenuContent);
        nav.SetMainContent(this.MainContent);
    }

    private void ContentPage_Loaded(object sender, EventArgs e)
    {
        var nav = NavigationService.GetInstance();
        nav.LoadMenu<MenuView>();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        var nav = NavigationService.GetInstance();
        nav.NavigateTo<Content1View>();
    }
}