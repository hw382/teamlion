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

        private string _pokeName;
        public string pokeName
        {
            get { return _pokeName; }
            set { _pokeName = value; }
        }        

        public Pokedex()
        {
            listOfPokemon = new ObservableCollection<Pokemon>();
        }

        public ObservableCollection<Pokemon> GetAllPokemon()
        {
            return listOfPokemon;
        }

        public ObservableCollection<Pokemon> AddPokemon()
        {
            listOfPokemon.Add(new Pokemon(pokeName, "sssss"));
            return listOfPokemon;
        }

        public ObservableCollection<Pokemon> DeletePokemon(Pokemon pokemon)
        {           
           // listOfPokemon.Remove(poke);
            return listOfPokemon;
        }
    }
}
