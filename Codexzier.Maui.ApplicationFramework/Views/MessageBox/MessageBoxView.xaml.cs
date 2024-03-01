using Codexzier.Maui.ApplicationFramework.Components.Data;
using Codexzier.Maui.ApplicationFramework.Components.Navigator;
using Codexzier.Maui.ApplicationFramework.Views.Base;

namespace Codexzier.Maui.ApplicationFramework.Views.MessageBox;

public partial class MessageBoxView : ContentView
{
	private MessageBoxViewModel _viewModel;
    public MessageBoxView()
	{
		InitializeComponent();

        ViewModelManager.Load<MessageBoxViewModel>(vm => this.BindingContext = vm);
    }
}

internal class MessageBoxViewModel : BaseViewModel
{
}

public static class ApplicationMessageBox
{
    public static void Show()
    {
        var instance = NavigationService.GetInstance();

        instance.ShowMessageBox<MessageBoxView>();
    }
}