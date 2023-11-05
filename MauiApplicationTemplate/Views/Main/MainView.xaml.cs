using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Codexzier.Maui.ApplicationFramework.Views.Base;

namespace MauiApplicationTemplate.Views.Main;

public partial class MainView : ContentView
{
    public MainViewModel _ViewModel;
    
    public MainView()
    {
        this.InitializeComponent();
        
        this._ViewModel = (MainViewModel)this.BindingContext;
    }
}

public class MainViewModel : BaseViewModel
{
}