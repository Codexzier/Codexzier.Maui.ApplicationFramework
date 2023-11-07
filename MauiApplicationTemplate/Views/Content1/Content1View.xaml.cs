using Codexzier.Maui.ApplicationFramework.Components.Navigator;

namespace MauiApplicationTemplate.Views.Conntent1;

public partial class Content1View : ContentView
{
    private Content1ViewModel _viewModel;
    
    public Content1View()
    {
        this.InitializeComponent();

        this._viewModel = (Content1ViewModel) this.BindingContext;
    }
}