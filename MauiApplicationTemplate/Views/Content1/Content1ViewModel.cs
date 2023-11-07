using System.Windows.Input;
using Codexzier.Maui.ApplicationFramework.Views.Base;
using MauiApplicationTemplate.Views.Content2;

namespace MauiApplicationTemplate.Views.Conntent1;

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