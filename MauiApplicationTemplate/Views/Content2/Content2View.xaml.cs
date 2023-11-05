using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApplicationTemplate.Views.Content2;

public partial class Content2View : ContentView
{
    private Content2ViewModel _ViewModel;
    public Content2View()
    {
        InitializeComponent();
        
        this._ViewModel = (Content2ViewModel)this.BindingContext;
    }
}

internal class Content2ViewModel
{
}