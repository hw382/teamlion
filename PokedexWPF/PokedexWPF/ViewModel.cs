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

        public ViewModel()
        {
            listOfPokemon = new ObservableCollection<Pokemon>()
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



        public bool CanSaveNewPokemon()
        {
            //if (newPokeN != null && newPokeT != null)
            if (string.IsNullOrEmpty())
            {
                return true;
            }

        }

        public void SaveNewPokemon()
        {

        }


    }
}
