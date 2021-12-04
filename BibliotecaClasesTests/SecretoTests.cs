using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BibliotecaClases.Tests
{
    [TestClass()]
    public class SecretoTests
    {
        Usuario u;
        Secreto s;

        [TestInitialize]
        public void SetUpTests()
        {
            u = new Usuario("gestor@ubusecret.es", "Gestor", "Ubu Secret", "Password");
            s = new Secreto(u, "El primer secreto", "Texto del primer secreto");
        }

        [TestMethod()]
        public void SecretoTest()
        {
            Assert.AreEqual(s.Propietario, u);
            Assert.AreEqual(s.Descripcion, "El primer secreto");
            Assert.AreEqual(s.Texto, "Texto del primer secreto");
        }

        [TestMethod()]
        public void EqualsTest()
        {
            Secreto s1 = new Secreto(u, "El segundo secreto", "Texto del primer secreto");
            s.IdSecreto = 1;
            s1.IdSecreto = 1;
            Assert.AreEqual(s, s1);

            s1.IdSecreto = 2;
            Assert.AreNotEqual(s, s1);

            Assert.AreNotEqual(s, "no es un secreto");
        }

        [TestMethod()]
        public void GetHashCodeTest()
        {
            Assert.IsNotNull(s.GetHashCode());
        }
    }
}