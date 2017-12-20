using Speq.Source.ViewModels;

namespace Speq.Source.Views {
    /// <summary>
    /// Interaction logic for DashboardTab.xaml
    /// </summary>
    public partial class DashboardTab : Tab {
        public DashboardTab () {
            InitializeComponent();
            DataContext = new DashboardTabViewModel();
        }
    }
}
