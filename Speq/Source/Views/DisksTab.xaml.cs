using Speq.Source.ViewModels;

namespace Speq.Source.Views {
    /// <summary>
    /// Interaction logic for DisksTab.xaml
    /// </summary>
    public partial class DisksTab : Tab {
        public DisksTab () : base( new DisksTabViewModel() ) {
            InitializeComponent();
        }
    }
}
