using Speq.Source.ViewModels;

namespace Speq.Source.Views {
    /// <summary>
    /// Interaction logic for MemoryTab.xaml
    /// </summary>
    public partial class MemoryTab : Tab {
        public MemoryTab () {
            InitializeComponent();
            DataContext = new MemoryTabViewModel();
        }
    }
}
