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
            }
            else
            {
                this.lblErrorNombre.Text = "";
            }
            if (this.tbxApellidos.Text == null || this.tbxApellidos.Text == "")
            {
                this.lblErrorApellidos.Text = "Apellidos no válidos";
            }
            else
            {
                this.lblErrorApellidos.Text = "";
            }
            Validador v = new Validador();
            if (v.EmailValido(this.tbxEmail.Text))
            {
                this.lblErrorEmail.Text = "";
                // Comprobación email en uso
                if (this.baseDeDatos.ExisteUsuarioEmail(this.tbxEmail.Text))
                {
                    this.lblErrorVentana.Text = "Email ya en uso";
                }
                else
                {
                    this.lblErrorVentana.Text = "";
                }
            }
            else
            {
                this.lblErrorEmail.Text = "Email no válido";
            }
            if (this.tbxPassword.Text == null || this.tbxPassword.Text == "" || this.tbxPassword.Text.Length < 6)
            {
                this.lblErrorPassword.Text = "Contraseña no válida (min 6 caracteres)";
            }
            else
            {
                this.lblErrorPassword.Text = "";
            }

            // Si no hay errores vamos a inicio de sesión
            if (this.lblErrorNombre.Text.Length == 0 && this.lblErrorApellidos.Text.Length == 0 &&
                this.lblErrorEmail.Text.Length == 0 && this.lblErrorVentana.Text.Length == 0)
            {
                this.registro();
            }
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