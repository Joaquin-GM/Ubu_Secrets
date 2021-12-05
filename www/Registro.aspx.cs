using BibliotecaClases;
using Data;
using System;

namespace www
{
    public partial class Registro : System.Web.UI.Page
    {
        DBPruebas baseDeDatos = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            baseDeDatos = (DBPruebas)Application["Datos"];
            if (baseDeDatos == null)
            {
                baseDeDatos = new DBPruebas();
                Application["Datos"] = baseDeDatos;
            }

            if (Session["uAutenticado"] != null)
            {
                // Sesión previa iniciada
                this.irAPanel();
            }

            if (!IsPostBack)
            {
                this.resetearErrores();
            }
        }

        protected void btnRegistro_Click(object sender, EventArgs e)
        {
            Server.Transfer("inicioSesion.aspx");
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            // Comprobaciones de campos
            if (this.tbxNombre.Text == null || this.tbxNombre.Text == "")
            {
                this.lblErrorNombre.Text = "Nombre no válido";
            } else {
                this.lblErrorNombre.Text = "";
            }
            if (this.lblErrorApellidos.Text == null || this.lblErrorApellidos.Text == "")
            {
                this.lblErrorNombre.Text = "Apellidos no válidos";
            } else
            {
                this.lblErrorNombre.Text = "";
            }
            Validador v = new Validador();
            if (v.EmailValido(this.tbxEmail.Text))
            {
                this.lblErrorEmail.Text = "";
            } else
            {
                this.lblErrorEmail.Text = "Email no válido";
            }
            if (this.lblErrorPassword.Text == null || this.lblErrorPassword.Text == ""  || this.lblErrorPassword.Text.Length < 6)
            {
                this.lblErrorPassword.Text = "Contraseña no válida (> 6 caracteres)";
            }
            else
            {
                this.lblErrorPassword.Text = "";
            }

            // Comprobación email en uso
        }
        protected void registro()
        {
            this.resetearErrores();
            Server.Transfer("InicioSesion.aspx");
        }

        protected void irAPanel()
        {
            this.resetearErrores();
            Server.Transfer("InicioSesion.aspx");
        }

        protected void resetearErrores()
        {
            this.lblErrorNombre.Text = "";
            this.lblErrorApellidos.Text = "";
            this.lblErrorEmail.Text = "";
            this.lblErrorPassword.Text = "";
            this.lblErrorVentana.Text = "";
        }
    }
}