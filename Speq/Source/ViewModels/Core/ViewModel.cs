using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Speq.Source.ViewModels.Core {
    public abstract class ViewModel : INotifyPropertyChanged {

        public event PropertyChangedEventHandler PropertyChanged = ( sender, args ) => { };

        protected virtual void OnPropertyChanged ( [CallerMemberName] string property = null ) {
            PropertyChanged( this, new PropertyChangedEventArgs( property ) );
        }

    }
}
