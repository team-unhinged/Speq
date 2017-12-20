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
                new TabItem() { Header = "Dashboard", Content = new DashboardTab() },
                new TabItem() { Header = "CPU", Content = new CPUTab() },
                new TabItem() { Header = "GPU", Content = new GPUTab() },
                new TabItem() { Header = "Disks", Content = new DisksTab() },
                new TabItem() { Header = "Memory", Content = new MemoryTab() },
                new TabItem() { Header = "Devices", Content = new DevicesTab() }
            };
        }
    }
}
