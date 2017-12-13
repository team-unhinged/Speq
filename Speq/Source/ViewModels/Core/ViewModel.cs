using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Speq.Source.ViewModels.Core {
    public abstract class ViewModel : INotifyPropertyChanged {

        public event PropertyChangedEventHandler PropertyChanged = ( sender, args ) => { };

        protected virtual void OnPropertyChanged ( [CallerMemberName] string property = null ) {
            PropertyChanged( this, new PropertyChangedEventArgs( property ) );
        }

    }
}
