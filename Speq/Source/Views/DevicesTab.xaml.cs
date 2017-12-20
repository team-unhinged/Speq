using Speq.Source.ViewModels;

namespace Speq.Source.Views {
    /// <summary>
    /// Interaction logic for DevicesTab.xaml
    /// </summary>
    public partial class DevicesTab : Tab {
        public DevicesTab () {
            InitializeComponent();
            DataContext = new DevicesTabViewModel();
        }
    }
}
