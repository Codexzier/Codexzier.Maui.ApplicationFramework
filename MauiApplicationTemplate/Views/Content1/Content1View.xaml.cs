using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

internal class Content1ViewModel
{
}