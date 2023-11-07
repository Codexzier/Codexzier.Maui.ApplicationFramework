using Codexzier.Maui.ApplicationFramework.Components.Navigator;
using Codexzier.Maui.ApplicationFramework.Views.Base;
using MauiApplicationTemplate.Views.Content2;
using System.Windows.Input;

namespace MauiApplicationTemplate.Views.Conntent1;

public partial class Content1View : ContentView
{
    private Content1ViewModel _viewModel;
    
    public Content1View()
    {
        this.InitializeComponent();

        this._viewModel = (Content1ViewModel) this.BindingContext;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        var nav = NavigationService.GetInstance();
        nav.NavigateTo<Content2View>();
    }
}

internal class Content1ViewModel : BaseViewModel
{
    private ICommand _commandTest;

    public Content1ViewModel()
    {
        this.CommandTest = new Command(() => this.Navigation.NavigateTo<Content2View>());
    }

    public ICommand CommandTest
    {
        get => this._commandTest;
        set
        {
            this._commandTest = value;
            this.OnNotifyPropertyChanged(nameof(this.CommandTest));
        }
    }
}