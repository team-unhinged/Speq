using Speq.Source.ViewModels;

namespace Speq.Source.Views {
    /// <summary>
    /// Interaction logic for GPUTab.xaml
    /// </summary>
    public partial class GPUTab : Tab {
        public GPUTab () {
            InitializeComponent();
            DataContext = new GPUTabViewModel();
        }
    }
}
