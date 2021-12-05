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

            if (Session["uAutenticado"] != null)
            {
                // Sesión previa iniciada
                this.iniciarSesion();
            }

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
                if (uAutenticado != null) {
                    if (!uAutenticado.ValidaPassword(this.tbxPassword.Text)) {
                        this.lblErrorVentana.Text = "Email y/o contraseña incorrecta";
                    } else
                    {
                        // COMRPROBACIONES EXTRA ACTIVO y AUTORIZADO
                        if (!uAutenticado.Activo)
                        {
                            this.lblErrorVentana.Text = "El usuario no está activo, por favor contacta con un administrador.";

                        } else if (uAutenticado.Bloqueado) {
                            this.lblErrorVentana.Text = "El usuario está bloqueado, por favor contacta con un administrador.";
                        }
                        else if (uAutenticado.Autorizado)
                        {
                            this.lblErrorVentana.Text = "El usuario no está autorizado, por favor contacta con un administrador.";
                        }
                        else
                        {
                            // INICIO SESIÓN
                            this.iniciarSesion();
                        }
                    }
                }
            } else
            {
                this.lblErrorEmail.Text = "Email no válido";
            }
        }

        protected void btnRegistro_Click(object sender, EventArgs e)
        {
            Server.Transfer("Registro.aspx");
        }

        protected void iniciarSesion()
        {
            this.lblErrorEmail.Text = "";
            this.lblErrorPassword.Text = "";
            this.lblErrorVentana.Text = "";
            Session["uAutenticado"] = uAutenticado;
            Server.Transfer("panel.aspx");
        }
    }
}