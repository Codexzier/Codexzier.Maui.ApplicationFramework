using Codexzier.Maui.ApplicationFramework.Components.Data;

namespace MauiApplicationTemplate.Views.Content2;

public partial class Content2View : ContentView
{
    private Content2ViewModel _ViewModel;

    public Content2View()
    {
        this.InitializeComponent();

        ViewModelManager.Load<Content2ViewModel>(vm => this.BindingContext = vm);
    }
}