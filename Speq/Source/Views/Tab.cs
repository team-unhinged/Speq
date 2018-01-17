using Speq.Source.ViewModels.Core;
using System.Windows.Controls;

namespace Speq.Source.Views {
    public class Tab : UserControl {

        public Tab ( ViewModel tabViewModel ) {
            DataContext = tabViewModel;
        }
    }
}
