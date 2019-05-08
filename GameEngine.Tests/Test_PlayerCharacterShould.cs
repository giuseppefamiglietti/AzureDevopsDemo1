using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameEngine.Tests
{
    [TestClass]
    public class Test_PlayerCharacterShould
    {
        //verifico che il parametro is Noob � true quando creo un nuovo PlayerCharacter
        [TestMethod]
        public void BeInexperiencedWhenNew()
        {
            var sut = new PlayerCharacter();

            Assert.IsFalse(sut.IsNoob);
        }
    }
}
