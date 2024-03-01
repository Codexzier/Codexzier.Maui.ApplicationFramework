using Codexzier.Maui.ApplicationFramework.Components.Data;
using Codexzier.Maui.ApplicationFramework.Components.Navigator;
using Codexzier.Maui.ApplicationFramework.Views.Base;
using System.Windows.Input;

namespace Codexzier.Maui.ApplicationFramework.Views.MessageBox;

public partial class MessageBoxView : ContentView, IMessageBoxView
{
    public MessageBoxView()
	{
		InitializeComponent();

        ViewModelManager.Load<MessageBoxViewModel>(vm => this.BindingContext = vm);
    }

    public void SetText(string title, string message)
    {
        var vm = (MessageBoxViewModel)this.BindingContext;

        vm.Title = title;
        vm.Message = message;
    }
}

internal interface IMessageBoxView
{
    void SetText(string title, string contextText);
}

internal class MessageBoxViewModel : BaseViewModel
{
    private string _title;
    private string _message;

    public ICommand CommandAccept { get; set; } = new ButtonCommandAccept();
    public ICommand CommandCancel { get; set; } = new ButtonCommandCancel();

    public string Title
    {
        get => _title;
        set
        {
            _title = value;
            this.OnNotifyPropertyChanged(nameof(Title));
        }
    }

    public string Message
    {
        get => _message; set
        {
            _message = value;
            this.OnNotifyPropertyChanged(nameof(Message));
        }
    }
}

internal class ButtonCommandCancel : BaseCommand
{
    public override void Execute(object parameter)
    {
        var instance = NavigationService.GetInstance();

        instance.HideMessageBox<MessageBoxView>();

        ApplicationMessageBox.MessageEvents.SendMessageBoxReturnResult(MessageBoxResult.Cancel);
    }
}

internal class ButtonCommandAccept : BaseCommand
{
    public override void Execute(object parameter)
    {
        var instance = NavigationService.GetInstance();

        instance.HideMessageBox<MessageBoxView>();

        ApplicationMessageBox.MessageEvents.SendMessageBoxReturnResult(MessageBoxResult.Accept);
    }
}

public class ApplicationMessageBox
{
    public static void Show<TView>(string title, string message) where TView : ContentView
    {
        var instance = NavigationService.GetInstance();

        instance.ShowMessageBox<TView>(out TView view);

        if(view is IMessageBoxView typeView)
        {
            typeView.SetText(title, message);
        }
    }

    public static MessageEventHolder MessageEvents { get; set; } = new MessageEventHolder();

    
}

public class MessageEventHolder
{
    public delegate void MessageBoxReturnResultEventHandler(MessageBoxResult result);
    public event MessageBoxReturnResultEventHandler MessageBoxReturnResultEvent;
    public void SendMessageBoxReturnResult(MessageBoxResult result)
    {
        this.MessageBoxReturnResultEvent?.Invoke(result);
    }
}