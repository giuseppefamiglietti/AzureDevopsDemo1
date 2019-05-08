using System;
using GameEngine;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyTests
{
    [TestClass]
    public class Test_PlayerCharacterShould
    {
        //verifico che il parametro is Noob è true quando creo un nuovo PlayerCharacter
        [TestMethod]
        public void BeInexperiencedWhenNew()
        {
            var sut = new PlayerCharacter();

            Assert.IsFalse(sut.IsNoob);
        }
    }
}
