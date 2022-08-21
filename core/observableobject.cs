using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ronald.core
{
    class observableobject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));


        }


    }
}
        