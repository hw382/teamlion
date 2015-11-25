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

        private ICommand _saveNewPokeCommand;
        public ICommand saveNewPokeCommand
        {
            get
            {
                if (_saveNewPokeCommand == null)
                {
                    _saveNewPokeCommand = new Command(SaveNewPokemon, CanSaveNewPokemon);
                }

                return _saveNewPokeCommand;
            }
            set { _saveNewPokeCommand = value; }
        }

        private readonly IList<PokemonTypes> types = new ObservableCollection<PokemonTypes>();
        public IList<PokemonTypes> Types
        {
            get
            {
                return types;
            }
        }

        private PokemonTypes _selectedType;

        public PokemonTypes selectedType
        {
            get { return _selectedType; }
            set 
            { 
                if (Object.Equals(selectedType, value))
                {
                    return;
                }
                _selectedType = value;
                OnPropertyChanged("selectedType");
            }
        }




        public ViewModel()
        {
            listOfPokemon = new ObservableCollection<Pokemon>()
            {                
                new Pokemon("Charmander", "Fire"),
                new Pokemon("Squirtle", "Water"),
                new Pokemon("Bulbasaur", "Grass")              
            };

            List<string> listOfTypes = new List<string>()
            {
                ("Normal", "Fire", "Water", "Electric", "Grass", "Ice", "Flying", "Fighting", "Poison", "Ground", "Psychic", "Bug", "Rock", "Ghost", "Steel", "Dark", "Dragon", "Fairy", "Legendary");
            };
        }



        //public ViewModel()
        //{
        //    types.Add(new PokemonTypes { type = "Normal" });
        //    types.Add(new PokemonTypes { type = "Fire" });
        //    types.Add(new PokemonTypes { type = "Water" });
        //    types.Add(new PokemonTypes { type = "Electric" });
        //    types.Add(new PokemonTypes { type = "Grass" });
        //    types.Add(new PokemonTypes { type = "Ice" });
        //    types.Add(new PokemonTypes { type = "Fighting" });
        //    types.Add(new PokemonTypes { type = "Poison" });
        //    types.Add(new PokemonTypes { type = "Ground" });
        //    types.Add(new PokemonTypes { type = "Flying" });
        //    types.Add(new PokemonTypes { type = "Psychic" });
        //    types.Add(new PokemonTypes { type = "Bug" });
        //    types.Add(new PokemonTypes { type = "Rock" });
        //    types.Add(new PokemonTypes { type = "Ghost" });
        //    types.Add(new PokemonTypes { type = "Dragon" });
        //    types.Add(new PokemonTypes { type = "Dark" });
        //    types.Add(new PokemonTypes { type = "Steel" });
        //    types.Add(new PokemonTypes { type = "Fairy" });
        //    types.Add(new PokemonTypes { type = "Legendary" });
            
        //}

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }



        public bool CanSaveNewPokemon()
        {
                return true;
        }

        public void SaveNewPokemon()
        {

        }


    }
}
