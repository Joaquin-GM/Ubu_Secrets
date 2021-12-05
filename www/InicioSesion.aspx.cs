using BibliotecaClases;
using Data;
using System;

namespace www
{
    public partial class WebForm1 : System.Web.UI.Page
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

            Session["uAutenticado"] = uAutenticado;

            if (!IsPostBack)
            {
                this.lblErrorEmail.Text = "";
                this.lblErrorPassword.Text = "";
                this.lblErrorVentana.Text = ""; // Error general
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Validador v = new Validador();
            if (v.EmailValido(this.tbxEmail.Text))
            {
                this.lblErrorEmail.Text = "";
                uAutenticado = this.baseDeDatos.LeeUsuario(this.tbxEmail.Text);
            } else
            {
                this.lblErrorEmail.Text = "Email no válido";
            }
           
        }

        protected void btnRegistro_Click(object sender, EventArgs e)
        {

        }
    }
}