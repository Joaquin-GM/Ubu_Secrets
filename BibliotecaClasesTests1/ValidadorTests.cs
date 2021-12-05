using Microsoft.VisualStudio.TestTools.UnitTesting;
using BibliotecaClases;
using System;
namespace BibliotecaClases.Tests
{
    [TestClass()]
    public class ValidadorTests
    {
        [TestMethod()]
        public void EmailValidoTest()
        {
            Validador v = new Validador();
            Assert.IsTrue(v.EmailValido("jgmolina@ubu.es"));
            Assert.IsTrue(v.EmailValido("joaquin@ubu.es"));
            Assert.IsTrue(v.EmailValido("otro@gmail.es"));
            Assert.IsFalse(v.EmailValido("otro@"));
            Assert.IsFalse(v.EmailValido("otro"));
            Assert.IsFalse(v.EmailValido(" "));
            Assert.IsFalse(v.EmailValido(""));
            Assert.IsFalse(v.EmailValido(null));
        }
    }
}