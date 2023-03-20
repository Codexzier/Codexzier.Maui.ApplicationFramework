using Codexzier.Maui.ApplicationFramework.Views.Base;

namespace Codexzier.Maui.ApplicationFramework.Views.ActiveLoading;

public partial class ActivityLoadingView
{
    internal class ActivityLoadingViewModel : BaseViewModel
    {
        private int _status;

        public int Status
        {
            get => this._status; set
            {
                this._status = value;
                this.OnNotifyPropertyChanged(nameof(this.Status));
            }
        }
    }
}