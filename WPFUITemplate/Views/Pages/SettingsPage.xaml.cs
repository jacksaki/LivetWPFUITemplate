using Wpf.Ui.Controls;
using WPFUITemplate.ViewModels.Pages;

namespace WPFUITemplate.Views.Pages
{
    public partial class SettingsPage : INavigableView<SettingsViewModel>
    {
        public SettingsViewModel ViewModel { get; }

        public SettingsPage(SettingsViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this.ViewModel;

            InitializeComponent();
        }
    }
}
