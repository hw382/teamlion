using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokedexWPF;
using Moq;

namespace PokedexTest
{
    [TestClass]
    public class RemovePokemonTest
    {
        [TestMethod]
        public void Test_CanRemovePokemon_ReturnsTrue_WhenCanRemovePokemonIsCalled()
        {
            ViewModel vm = new ViewModel(new Pokedex());

            bool returnBool = vm.CanRemovePokemon();

            Assert.AreEqual(true, returnBool);

        }

        [TestMethod]
        public void Test_DeletePokemon_RemovePokemonMethodCallsDeletePokemonMethod_WhenRemovePokemonIsCalled()
        {
            Mock<Pokedex> mockPokedex = new Mock<Pokedex>();
            ViewModel vm = new ViewModel(mockPokedex.Object);

            vm.RemovePokemon();

            mockPokedex.Verify(x => x.DeletePokemon(), Times.Once);
        }
    }
}
