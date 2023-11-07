using System.Windows.Input;
using Codexzier.Maui.ApplicationFramework.Views.Base;
using MauiApplicationTemplate.Views.Conntent1;

namespace MauiApplicationTemplate;

// ONLY FOR TESTING
internal class MainPageViewModel : BaseViewModel
{
    private ICommand _executeCommand;
    
    public MainPageViewModel()
    {
        this.ExecuteCommand = new Command(() => this.Navigation.NavigateTo<Content1View>());
    }

    public ICommand ExecuteCommand
    {
        get => this._executeCommand;
        set
        {
            this._executeCommand = value;
            this.OnNotifyPropertyChanged(nameof(this.ExecuteCommand));
        }
    }
}