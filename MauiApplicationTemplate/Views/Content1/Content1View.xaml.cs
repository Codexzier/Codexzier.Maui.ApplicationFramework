using Codexzier.Maui.ApplicationFramework.Components.Data;
using Codexzier.Maui.ApplicationFramework.Components.Navigator;

namespace MauiApplicationTemplate.Views.Conntent1;

public partial class Content1View : ContentView
{
    private Content1ViewModel _viewModel;
    
    public Content1View()
    {
        this.InitializeComponent();

        ViewModelManager.Load<Content1ViewModel>(vm => this.BindingContext = vm);
    }
}