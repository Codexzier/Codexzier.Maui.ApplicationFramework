﻿using Codexzier.Maui.ApplicationFramework.Components.Data;

namespace MauiApplicationTemplate.Views.Content1;

public partial class Content1View : ContentView
{
    private Content1ViewModel _viewModel;
    
    public Content1View()
    {
        this.InitializeComponent();

        ViewModelManager.Load<Content1ViewModel>(vm => this.BindingContext = vm);
    }
}