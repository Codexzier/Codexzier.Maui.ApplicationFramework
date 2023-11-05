using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Codexzier.Maui.ApplicationFramework.Views.Base;
using MauiApplicationTemplate.Views.Conntent1;
using MauiApplicationTemplate.Views.Content2;

namespace MauiApplicationTemplate.Views.Menu;

public partial class MenuView : ContentView
{
    private MenuViewModel _viewModel;
    
    public MenuView()
    {
        this.InitializeComponent();
        
        this._viewModel = (MenuViewModel)this.BindingContext;
    }
}

internal class MenuViewModel : BaseViewModel
{
    private ICommand _commandOpenContent1;
    private ICommand _commandOpenContent2;

    public MenuViewModel()
    {
        this.CommandOpenContent1 = new Command(() => this.NavigationService.NavigateTo<Content1View>());
        this.CommandOpenContent2 = new Command(() => this.NavigationService.NavigateTo<Content2View>());
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