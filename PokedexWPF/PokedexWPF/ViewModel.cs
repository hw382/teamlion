using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PokedexWPF
{
    public class ViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Pokemon> _listOfPokemon;
        public ObservableCollection<Pokemon> listOfPokemon
        {
            get { return _listOfPokemon; }
            set { _listOfPokemon = value; OnPropertyChanged("listOfPokemon"); }
        }

        private Pokedex _pokedex;
        public Pokedex pokedex
        {
            get { return _pokedex; }
            set { _pokedex = value; }
        }


        private ICommand _RemovePokemonCommand;
        public ICommand addPokemonCommandommand
        {
            get 
            {
                if (_RemovePokemonCommand == null) 
                {
                    _RemovePokemonCommand = new Command(RemovePokemon, CanRemovePokemon);
                }
                return _RemovePokemonCommand; 
            }
            set { _RemovePokemonCommand = value; }
        }
        
        public ViewModel(Pokedex pokedex)
        {
            this.pokedex = pokedex;

            listOfPokemon = new ObservableCollection<Pokemon>()
            {                
                //new Pokemon("Charmander", "Fire"),
                //new Pokemon("Squirtle", "Water"),
                //new Pokemon("Bulbasaur", "Grass")              
            };
        }

        public bool CanRemovePokemon()
        {
            return true;
        }

        public void RemovePokemon()
        {
            pokedex.DeletePokemon();
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
