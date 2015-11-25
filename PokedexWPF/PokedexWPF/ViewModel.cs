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
        private string _pokeName;
        public string pokeName
        {
            get { return _pokeName; }
            set { _pokeName = value; }
        }

        private string _pokeType;
        public string pokeType
        {
            get { return _pokeType; }
            set { _pokeType = value; }
        }

        private Pokemon _pokemon;
        public Pokemon pokemon
        {
            get { return _pokemon; }
            set { _pokemon = value; }
        }
        

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
            set { _pokedex = value; OnPropertyChanged("pokedex"); }
        }

        private List<string> _ListOfTypes;
        public List<string> ListOfTypes
        {
            get { return _ListOfTypes; }
            set { _ListOfTypes = value; }
        }

        private ICommand _removePokemonCommand;
        public ICommand removePokemonCommand
        {
            get
            {
                if (_removePokemonCommand == null)
                {
                    _removePokemonCommand = new Command(RemovePokemon, CanRemovePokemon);
                }
                return _removePokemonCommand;
            }
            set { _removePokemonCommand = value; }
        }

        private ICommand _addPokemonCommand;
        public ICommand addPokemonCommand
        {
            get
            {
                if (_addPokemonCommand == null)
                {
                    _addPokemonCommand = new Command(AddPokemon, CanAddPokemon);
                }
                return _addPokemonCommand;
            }
            set { _addPokemonCommand = value; }
        }       
        
        public ViewModel()
        {
            this.pokedex = pokedex;
            ListOfTypes = new List<string>() 
            {
                "Electric","Fire","Grass","Water","Psychic"            
            };

            listOfPokemon = new ObservableCollection<Pokemon>()
            {
                new Pokemon("Charmander", "Fire"),
                new Pokemon("Squirtle", "Water"),
                new Pokemon("Bulbasaur", "Grass")              
            };
        }

        public bool CanRemovePokemon()
        {
            return true;
        }

        public void RemovePokemon()
        {
            listOfPokemon.Remove(pokemon);
        }

        private bool CanAddPokemon()
        {
            return true;
        }

        private void AddPokemon()
        {
            listOfPokemon.Add(new Pokemon(pokeName, pokeType));
            //pokedex.AddPokemon();
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
