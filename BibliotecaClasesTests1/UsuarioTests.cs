using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BibliotecaClases.Tests
{
    [TestClass()]
    public class UsuarioTests
    {
        Usuario u;
        [TestInitialize]
        public void SetUpTests()
        {
            u = new Usuario("gestor@ubusecret.es", "Gestor", "Ubu Secret", "Password");
        }

        [TestMethod()]
        public void UsuarioTest()
        {
            Assert.AreEqual(u.Email, "gestor@ubusecret.es");
            Assert.AreEqual(u.Nombre, "Gestor");
            Assert.AreEqual(u.Apellidos, "Ubu Secret");
            Assert.AreEqual(u.EsGestor, false);
            Assert.AreEqual(u.Password, Encriptador.Encriptar("Password"));
            Assert.IsFalse(u.Activo);
            Assert.IsNotNull(u.IdUsuario);
            Assert.IsNotNull(u.UltimaActividad);
            Assert.IsNotNull(u.UltimaIp);
        }

        [TestMethod()]
        public void EqualsTest()
        {
            Usuario u1 = new Usuario("gestor@ubusecret.es", "Gestor1", "Ubu Secret", "Password");
            Assert.AreEqual(u, u1);
            u1.Email = "otroemail@ubu.es";
            Assert.AreNotEqual(u, u1);
            Assert.AreNotEqual(u, "no es un usuario");
        }

        [TestMethod()]
        public void GetHashCodeTest()
        {
            Assert.IsNotNull(u.GetHashCode());
        }

        [TestMethod()]
        public void ActivarTest()
        {
            u.Activar();
            Assert.IsTrue(u.Activo);
        }

        [TestMethod()]
        public void DesactivarTest()
        {
            u.Desactivar();
            Assert.IsFalse(u.Activo);
        }

        [TestMethod()]
        public void AutorizarTest()
        {
            u.Autorizar();
            Assert.IsTrue(u.Autorizado);
        }

        [TestMethod()]
        public void DesAutorizarTest()
        {
            u.DesAutorizar();
            Assert.IsFalse(u.Autorizado);
        }

        [TestMethod()]
        public void BloquearTest()
        {
            u.Bloquear();
            Assert.IsTrue(u.Bloqueado);
        }

        [TestMethod()]
        public void DesBloquearTest()
        {
            u.DesBloquear();
            Assert.IsFalse(u.Bloqueado);
        }

        [TestMethod()]
        public void CambiaPasswordTest()
        {
            Assert.IsTrue(u.CambiaPassword("Password", "NuevaPassword"));
            Assert.AreEqual(u.Password, Encriptador.Encriptar("NuevaPassword"));
            Assert.AreEqual(Encriptador.DesEncriptar(u.Password), "NuevaPassword");
            Assert.IsFalse(u.CambiaPassword("passwordMal", "otraPassword"));
        }

        [TestMethod()]
        public void ValidaPasswordTest()
        {
            Assert.IsTrue(u.ValidaPassword("Password"));
            Assert.IsFalse(u.ValidaPassword("passwordMal"));
        }
    }
}