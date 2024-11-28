using Livet;
using System.Windows.Media;
using Wpf.Ui.Controls;
using WPFUITemplate.Models;

namespace WPFUITemplate.ViewModels.Pages
{
    public class HomeViewModel : NotificationObject, INavigationAware
    {
        private bool _isInitialized = false;

        public void OnNavigatedTo()
        {
            if (!_isInitialized)
                InitializeViewModel();
        }

        public void OnNavigatedFrom() { }

        private void InitializeViewModel()
        {
            _isInitialized = true;
        }
    }
}
