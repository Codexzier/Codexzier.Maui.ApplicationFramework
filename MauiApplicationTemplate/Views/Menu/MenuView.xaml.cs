namespace MauiApplicationTemplate.Views.Menu;

public partial class MenuView : ContentView
{
    private MenuViewModel _viewModel;

    public MenuView()
    {
        this.InitializeComponent();

        this._viewModel = (MenuViewModel) this.BindingContext;
    }
}