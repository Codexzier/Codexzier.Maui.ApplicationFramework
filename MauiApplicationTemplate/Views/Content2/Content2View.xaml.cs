namespace MauiApplicationTemplate.Views.Content2;

public partial class Content2View : ContentView
{
    private Content2ViewModel _ViewModel;

    public Content2View()
    {
        this.InitializeComponent();

        this._ViewModel = (Content2ViewModel) this.BindingContext;
    }
}