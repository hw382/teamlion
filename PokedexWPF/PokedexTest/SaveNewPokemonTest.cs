using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PokedexWPF;

namespace PokedexTest
{
    [TestClass]
    public class SaveNewPokemonTest
    {
        [TestMethod]
        public void Test_SaveNewPokemon_CallsTheSaveNewPokemonMethodWhenButtonIsClicked()
        {
            //arrange
            Mock<Pokedex> mockDex = new Mock<Pokedex>();

            //act


            //assert
            //mockDex.Verify(s => s.AddPokemon(It.IsAny<Pokemon>))
        }
    }
}
