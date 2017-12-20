using Speq.Source.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Speq.Source.Views {
    /// <summary>
    /// Interaction logic for CPUTab.xaml
    /// </summary>
    public partial class CPUTab : Tab {
        public CPUTab () {
            InitializeComponent();
            DataContext = new CPUTabViewModel();
        }
    }
}
