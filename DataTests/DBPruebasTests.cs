using BibliotecaClases;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Data.Tests
{
    [TestClass()]
    public class DBPruebasTests
    {
        DBPruebas BaseDeDatos;

        [TestInitialize]
        public void SetUpTests()
        {
            BaseDeDatos = new DBPruebas();
        }

        [TestMethod()]
        public void DBPruebasTest()
        {
            Assert.IsNotNull(BaseDeDatos);
        }

        [TestMethod()]
        public void ActualizaSecretoTest()
        {
            Usuario u = new Usuario("gestorNuevo@ubusecret.es", "Gestor", "Ubu Secret", "Password");
            Secreto s = new Secreto(u, "El primer secreto", "Texto del primer secreto");
            BaseDeDatos.InsertaUsuario(u);
            BaseDeDatos.InsertaSecreto(s);
            s = BaseDeDatos.LeeSecreto(BaseDeDatos.SiguienteSecreto() - 1);
            s.Descripcion = "Nueva descripción";
            Assert.IsTrue(BaseDeDatos.ActualizaSecreto(s));
            Assert.AreEqual(s.Descripcion, "Nueva descripción");

            Secreto s1 = new Secreto(u, "Otro secreto", "Texto del otro secreto");
            s1.IdSecreto = 1000;
            Assert.IsFalse(BaseDeDatos.ActualizaSecreto(s1));
        }

        [TestMethod()]
        public void ActualizaUsuarioTest()
        {
            Usuario u = new Usuario("gestorNuevo@ubusecret.es", "Gestor", "Ubu Secret", "Password");
            BaseDeDatos.InsertaUsuario(u);
            u.Nombre = "Nombre actualizado";
            Assert.IsTrue(BaseDeDatos.ActualizaUsuario(u));
            Assert.AreEqual(u.Nombre, "Nombre actualizado");

            Usuario u1 = new Usuario("otroEmail@ubusecret.es", "Otro gestor", "Ubu Secret", "Password");
            Assert.IsFalse(BaseDeDatos.ActualizaUsuario(u1));
        }

        [TestMethod()]
        public void BorraSecretoTest()
        {
            Usuario u = new Usuario("gestorNuevo@ubusecret.es", "Gestor", "Ubu Secret", "Password");
            Secreto s = new Secreto(u, "El primer secreto", "Texto del primer secreto");
            BaseDeDatos.InsertaUsuario(u);
            BaseDeDatos.InsertaSecreto(s);
            Assert.IsTrue(BaseDeDatos.BorraSecreto(s.IdSecreto));
            Assert.IsFalse(BaseDeDatos.BorraSecreto(s.IdSecreto));
        }

        [TestMethod()]
        public void BorraSecretoTest1()
        {
            Usuario u = new Usuario("gestorNuevo@ubusecret.es", "Gestor", "Ubu Secret", "Password");
            Secreto s = new Secreto(u, "El primer secreto", "Texto del primer secreto");
            BaseDeDatos.InsertaUsuario(u);
            BaseDeDatos.InsertaSecreto(s);
            Assert.IsTrue(BaseDeDatos.BorraSecreto(s));
            Assert.IsFalse(BaseDeDatos.BorraSecreto(s));
        }

        [TestMethod()]
        public void BorraUsuarioTest()
        {
            Usuario u = new Usuario("gestorNuevo@ubusecret.es", "Gestor", "Ubu Secret", "Password");
            BaseDeDatos.InsertaUsuario(u);
            u = BaseDeDatos.LeeUsuario(u.Email);
            Assert.IsTrue(BaseDeDatos.BorraUsuario(u.Email));
            Assert.IsFalse(BaseDeDatos.BorraUsuario(u.Email));
        }

        [TestMethod()]
        public void BorraUsuarioTest1()
        {
            Usuario u = new Usuario("gestorNuevo@ubusecret.es", "Gestor", "Ubu Secret", "Password");
            BaseDeDatos.InsertaUsuario(u);
            u = BaseDeDatos.LeeUsuario(u.Email);
            Assert.IsTrue(BaseDeDatos.BorraUsuario(u.IdUsuario));
            Assert.IsFalse(BaseDeDatos.BorraUsuario(u.IdUsuario));
        }

        [TestMethod()]
        public void ExisteUsuarioEmailTest()
        {
            Usuario u = new Usuario("gestorNuevo@ubusecret.es", "Gestor", "Ubu Secret", "Password");
            BaseDeDatos.InsertaUsuario(u);
            Assert.IsTrue(BaseDeDatos.ExisteUsuarioEmail(u.Email));
            Assert.IsFalse(BaseDeDatos.ExisteUsuarioEmail("otroEmail@ubu.es"));
        }

        [TestMethod()]
        public void InsertaSecretoTest()
        {
            Usuario u = new Usuario("gestorNuevo@ubusecret.es", "Gestor", "Ubu Secret", "Password");
            Secreto s = new Secreto(u, "El primer secreto", "Texto del primer secreto");
            Assert.IsTrue(BaseDeDatos.InsertaSecreto(s));
            s = BaseDeDatos.LeeSecreto(BaseDeDatos.SiguienteSecreto() - 1);
            Assert.IsFalse(BaseDeDatos.InsertaSecreto(s));
        }

        [TestMethod()]
        public void InsertaUsuarioTest()
        {
            Usuario u = new Usuario("gestorNuevo@ubusecret.es", "Gestor", "Ubu Secret", "Password");
            Assert.IsTrue(BaseDeDatos.InsertaUsuario(u));
            u = BaseDeDatos.LeeUsuario(u.Email);
            Assert.IsFalse(BaseDeDatos.InsertaUsuario(u));
        }

        [TestMethod()]
        public void LeeSecretoTest()
        {
            Assert.IsNotNull(BaseDeDatos.LeeSecreto(1));
            Assert.IsNull(BaseDeDatos.LeeSecreto(123));
        }

        [TestMethod()]
        public void LeeUsuarioTest()
        {
            Assert.IsNotNull(BaseDeDatos.LeeUsuario("gestor@ubusecret.es"));
            Assert.IsNull(BaseDeDatos.LeeUsuario("otroemail@ubusecret.es"));
        }

        [TestMethod()]
        public void LeeUsuarioTest1()
        {
            Assert.IsNotNull(BaseDeDatos.LeeUsuario(1));
            Assert.IsNull(BaseDeDatos.LeeUsuario(12345));
        }

        [TestMethod()]
        public void NumeroSecretosTest()
        {
            Assert.IsTrue(BaseDeDatos.NumeroSecretos() > 0);
        }

        [TestMethod()]
        public void NumeroUsuariosTest()
        {
            Assert.IsTrue(BaseDeDatos.NumeroUsuarios() > 0);
        }

        [TestMethod()]
        public void SiguienteSecretoTest()
        {
            Assert.IsNotNull(BaseDeDatos.SiguienteSecreto());
        }

        [TestMethod()]
        public void SiguienteUsuarioTest()
        {
            Assert.IsNotNull(BaseDeDatos.SiguienteUsuario());
        }
    }
}