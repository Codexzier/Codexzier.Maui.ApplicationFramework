using System.ComponentModel;

namespace Codexzier.Maui.ApplicationFramework.Components.Data
{
    public class ViewModelManager
    {
        private static readonly Dictionary<Type, object> _viewModelHolder = new();

        private ViewModelManager()
        {
        }

        public static void Load<TViewModel>(Action<INotifyPropertyChanged> func) where TViewModel : INotifyPropertyChanged
        {
            var t = typeof(TViewModel);
            INotifyPropertyChanged bindingViewModel;

            if (_viewModelHolder.TryGetValue(t, out var value))
            {
                bindingViewModel = (TViewModel)value;
            }
            else
            {
                bindingViewModel = Activator.CreateInstance<TViewModel>();
                _viewModelHolder.Add(t, bindingViewModel);
            }

            func(bindingViewModel);
        }
    }
}
