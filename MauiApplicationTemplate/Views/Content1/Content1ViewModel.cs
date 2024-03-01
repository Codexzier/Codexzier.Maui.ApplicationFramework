using System.Windows.Input;
using Codexzier.Maui.ApplicationFramework.Views.Base;
using Codexzier.Maui.ApplicationFramework.Views.MessageBox;
using MauiApplicationTemplate.Views.Content2;

namespace MauiApplicationTemplate.Views.Content1;

internal class Content1ViewModel : BaseViewModel
{
    private ICommand _commandTest;
    private string _messageBoxResultText;

    public Content1ViewModel()
    {
        this.CommandTest = new Command(() => this.Navigation.NavigateTo<Content2View>());

        this.CommandMessageBox = new Command(() =>
        {
            ApplicationMessageBox.Show<MessageBoxView>("Der Titel", "Der Inhaltliche Text");
        });

        this.ApplicationMessageBox_MessageBoxReturnResultEvent(MessageBoxResult.None);
        ApplicationMessageBox.MessageEvents.MessageBoxReturnResultEvent += this.ApplicationMessageBox_MessageBoxReturnResultEvent;
    }

    ~Content1ViewModel()
    {
        ApplicationMessageBox.MessageEvents.MessageBoxReturnResultEvent -= this.ApplicationMessageBox_MessageBoxReturnResultEvent;
    }

    private void ApplicationMessageBox_MessageBoxReturnResultEvent(Codexzier.Maui.ApplicationFramework.Views.MessageBox.MessageBoxResult result)
    {
        this.MessageBoxResultText = $"Result: {result}, Datum: {DateTime.Now:T}";
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

    public ICommand CommandMessageBox { get; set; }

    public string MessageBoxResultText
    {
        get => _messageBoxResultText; set
        {
            _messageBoxResultText = value;
            this.OnNotifyPropertyChanged(nameof(this.MessageBoxResultText));
        }
    }
}