using Speq.Source.ViewModels.Core;
using Speq.Source.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Speq.Source.ViewModels {
    public class MainWindowViewModel : ViewModel {

        public ObservableCollection<TabItem> SpeqTabs { get; set; }
        
        public MainWindowViewModel () {
            SpeqTabs = new ObservableCollection<TabItem> {
                new TabItem() { Header = "CPU", Content = new CPUTab() }
            };
        }
    }
}
