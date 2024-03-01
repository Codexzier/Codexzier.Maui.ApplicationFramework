using System.Windows.Input;
using Codexzier.Maui.ApplicationFramework.Views.Base;
using MauiApplicationTemplate.Views.Content1;
using MauiApplicationTemplate.Views.Content2;

namespace MauiApplicationTemplate.Views.Menu;

internal class MenuViewModel : BaseViewModel
{
    private ICommand _commandOpenContent1;
    private ICommand _commandOpenContent2;

    public MenuViewModel()
    {
        this.CommandOpenContent1 = new Command(() => this.Navigation.NavigateTo<Content1View>());
        this.CommandOpenContent2 = new Command(() => this.Navigation.NavigateTo<Content2View>());
    }
    
    public ICommand CommandOpenContent1
    {
        get => this._commandOpenContent1;
        set
        {
            this._commandOpenContent1 = value;
            this.OnNotifyPropertyChanged(nameof(this.CommandOpenContent1));
        }
    }
    
    public ICommand CommandOpenContent2
    {
        get => this._commandOpenContent2;
        set
        {
            this._commandOpenContent2 = value;
            this.OnNotifyPropertyChanged(nameof(this.CommandOpenContent2));
        }
    }
}