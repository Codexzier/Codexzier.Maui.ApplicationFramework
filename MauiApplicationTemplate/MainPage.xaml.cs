using Codexzier.Maui.ApplicationFramework.Components.Navigator;
using MauiApplicationTemplate.Views.Menu;

namespace MauiApplicationTemplate;

public partial class MainPage : ContentPage
{
    
    public MainPage()
    {
        this.InitializeComponent();
        
        var nav = NavigationService.GetInstance();
        
        nav.SetMenuContent(this.MenuContent);
        nav.SetMainContent(this.MainContent);

        nav.SetMessageBoxContent(this.MessageBoxContent);
    }

    private void ContentPage_Loaded(object sender, EventArgs e)
    {
        var nav = NavigationService.GetInstance();
        nav.LoadMenu<MenuView>();
    }
}