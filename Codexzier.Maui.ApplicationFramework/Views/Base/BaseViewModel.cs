using System.ComponentModel;
using Codexzier.Maui.ApplicationFramework.Components.Navigator;

namespace Codexzier.Maui.ApplicationFramework.Views.Base
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnNotifyPropertyChanged(string propertyName) => this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        protected INavigationService Navigation => NavigationService.GetInstance();
    }
}
