using Livet;
using System.Collections.ObjectModel;
using Wpf.Ui.Controls;
using WPFUITemplate.Models;

namespace WPFUITemplate.ViewModels.Windows
{
    public class MainWindowViewModel : ViewModel
    {

        private string _ApplicationTitle = "WPF UI - WPFUITemplate";
        public ObservableCollection<NavigationViewItem> MenuItems { get; }
        public ObservableCollection<NavigationViewItem> FooterMenuItems { get; }
        public ObservableCollection<MenuItem> TrayMenuItems { get; }

        public string ApplicationTitle
        {
            get
            {
                return _ApplicationTitle;
            }
            set
            { 
                if (_ApplicationTitle == value)
                {
                    return;
                }
                _ApplicationTitle = value;
                RaisePropertyChanged();
            }
        }

        public MainWindowViewModel()
        {
            this.MenuItems = new ObservableCollection<NavigationViewItem>()
            {
                new NavigationViewItem()
                {
                    Content = "Home",
                    Icon = new SymbolIcon { Symbol = SymbolRegular.Home24 },
                    TargetPageType = typeof(Views.Pages.HomePage)
                },
            };
            this.FooterMenuItems = new ObservableCollection<NavigationViewItem>()
            {
                new NavigationViewItem()
                {
                    Content = "Settings",
                    Icon = new SymbolIcon { Symbol = SymbolRegular.Settings24 },
                    TargetPageType = typeof(Views.Pages.SettingsPage)
                }
            };
            this.TrayMenuItems = new ObservableCollection<MenuItem>()
            {
                new MenuItem { Header = "Home", Tag = "tray_home" }
            };
        }
    }
}
