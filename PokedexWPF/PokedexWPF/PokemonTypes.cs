using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexWPF
{
    class PokemonTypes : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged(string propertyName)
        {
            var localEvent = PropertyChanged;
            if (localEvent != null)
            {
                localEvent.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private string _type;
        public string type
        {
            get { return _type; }
            set
            {
                if (string.Equals(_type, value))
                {
                    return;
                }
                _type = value;
                RaisePropertyChanged("type");
            }
        }        


        //end of class
    }
}
