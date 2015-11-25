using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.ObjectModel;
using PokedexWPF;

namespace PokedexTest
{
    [TestClass]
    public class PokedexTest
    {
        Pokedex pokedex;

        [TestInitialize]
        public void Setup() 
        {
            pokedex = new Pokedex();
        }

        [TestMethod]
        public void Test_GetAllPokemon_ReturnsAListOfLengthZero_WhenNoPokemonHasBeenAdded()
        {
            ObservableCollection<Pokemon> listOfPokemon = pokedex.GetAllPokemon();

            Assert.AreEqual(0, listOfPokemon.Count);
        }

        [TestMethod]
        public void Test_GetAllPokemon_ReturnsAListOfLengthOne_WhenOnePokemonHasBeenAdded()
        {
            ObservableCollection<Pokemon> listOfPokemon = pokedex.GetAllPokemon();
            listOfPokemon.Add(new Pokemon("Pikachu", "Electric"));

            Assert.AreEqual(1, listOfPokemon.Count);
        }

        [TestMethod]
        public void Test_GetAllPokemon_ReturnsAListOfLengthTwo_WhenTwoPokemonHasBeenAdded()
        {
            ObservableCollection<Pokemon> listOfPokemon = pokedex.GetAllPokemon();
            listOfPokemon.Add(new Pokemon("Pikachu", "Electric"));
            listOfPokemon.Add(new Pokemon("Bulbasaur", "Grass"));

            Assert.AreEqual(2, listOfPokemon.Count);
        }

        [TestMethod]
        public void Test_AddPokemon_ReturnsAListOfLengthOne_WhenOnePokemonHasBeenPassedAndTheAddPokemonIsCalled()
        {
            ObservableCollection<Pokemon> listOfPokemon = pokedex.GetAllPokemon();
            pokedex.AddPokemon(new Pokemon("Pikachu", "Electric"));            

            Assert.AreEqual(1, listOfPokemon.Count);
        }

        [TestMethod]
        public void Test_AddPokemon_ReturnsAListOfLengthTwo_WhenOnePokemonHasBeenPassedAndTheAddPokemonIsCalled()
        {
            ObservableCollection<Pokemon> listOfPokemon = pokedex.GetAllPokemon();
            pokedex.AddPokemon(new Pokemon("Pikachu", "Electric"));
            pokedex.AddPokemon(new Pokemon("Bulbasuar", "Grass"));

            Assert.AreEqual(2, listOfPokemon.Count);
        }


        [TestMethod]
        public void Test_AddPokemon_ReturnsAListOfLengthThree_WhenOnePokemonHasBeenPassedAndThePokemonIsCalled()
        {
            ObservableCollection<Pokemon> listOfPokemon = pokedex.GetAllPokemon();
            pokedex.AddPokemon(new Pokemon("Pikachu", "Electric"));
            pokedex.AddPokemon(new Pokemon("Bulbasuar", "Grass"));
            pokedex.AddPokemon(new Pokemon("Charmander", "Fire"));

            Assert.AreEqual(3, listOfPokemon.Count);
        }
    }
}
