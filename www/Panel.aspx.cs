using BibliotecaClases;
using Data;
using System;

namespace www
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        Usuario uAutenticado = null;
        DBPruebas baseDeDatos = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            baseDeDatos = (DBPruebas)Application["Datos"];
            if (baseDeDatos == null)
            {
                baseDeDatos = new DBPruebas();
                Application["Datos"] = baseDeDatos;
            }

            uAutenticado = (Usuario)Session["uAutenticado"];
            if (uAutenticado == null) {
                Server.Transfer("InicioSesion.aspx");
            }

            this.lblUsuario.Text = uAutenticado.Email;
        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            uAutenticado = null;
            Session["uAutenticado"] = uAutenticado;
            Server.Transfer("InicioSesion.aspx");
        }
    }
}