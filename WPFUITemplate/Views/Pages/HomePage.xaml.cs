using Wpf.Ui.Controls;
using WPFUITemplate.ViewModels.Pages;

namespace WPFUITemplate.Views.Pages
{
    public partial class HomePage : INavigableView<HomeViewModel>
    {
        public HomeViewModel ViewModel { get; }

        public HomePage(HomeViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this.ViewModel;

            InitializeComponent();
        }
    }
}
