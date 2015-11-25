using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexWPF
{
    public class ViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Pokemon> _pokedex;
        public ObservableCollection<Pokemon> pokedex
        {
            get { return _pokedex; }
            set { _pokedex = value; OnPropertyChanged("pokemon"); }
        }


        public ViewModel()
        {
            pokedex = new ObservableCollection<Pokemon>()
            {                
                new Pokemon("Charmander", "Fire"),
                new Pokemon("Squirtle", "Water"),
                new Pokemon("Bulbasaur", "Grass")
              
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
