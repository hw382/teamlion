using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexWPF
{
    public class Pokedex
    {        
        private ObservableCollection<Pokemon> _listOfPokemon;
        public ObservableCollection<Pokemon> listOfPokemon
        {
            get { return _listOfPokemon; }
            set { _listOfPokemon = value; }
        }

        MainWindow mw;

        public Pokedex()
        {
            mw = new MainWindow();
            listOfPokemon = new ObservableCollection<Pokemon>();
        }

        public ObservableCollection<Pokemon> GetAllPokemon()
        {
            return listOfPokemon;
        }

        public ObservableCollection<Pokemon> AddPokemon(Pokemon pokemon)
        {
            listOfPokemon.Add(pokemon);
            return listOfPokemon;
        }

        public ObservableCollection<Pokemon> DeletePokemon()
        {
           // listOfPokemon.Remove();
            return listOfPokemon;
        }
    }
}
