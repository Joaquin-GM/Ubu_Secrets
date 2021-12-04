using System;

namespace BibliotecaClases
{
    public class Usuario
    {
        private int idUsuario;
        private string nombre;
        private string apellidos;
        private string email;
        private string password;
        private string ultimaIp;
        private DateTime ultimaActividad;
        private bool esGestor;
        private bool activo;
        private bool autorizado;
        private bool bloqueado;

        public Usuario(string email, string nombre, string apellidos, string password)
        {
            this.idUsuario = -1;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.email = email;
            this.password = password;
            this.Encriptar();
            this.Activo = false; // un usuario Admin tendrá que activarlo
            this.Bloqueado = false;
            this.EsGestor = false;
            this.ultimaActividad = new DateTime();
            this.ultimaIp = "127.0.0.1";
        }

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public DateTime UltimaActividad { get => ultimaActividad; set => ultimaActividad = value; }
        public string UltimaIp { get => ultimaIp; set => ultimaIp = value; }
        public bool Activo { get => activo; set => activo = value; }
        public bool EsGestor { get => esGestor; set => esGestor = value; }
        public bool Autorizado { get => autorizado; set => autorizado = value; }
        public bool Bloqueado { get => bloqueado; set => bloqueado = value; }

        public override bool Equals(object obj)
        {
            return obj is Usuario usuario &&
                   Email == usuario.Email;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(idUsuario);
        }

        public void Activar()
        {
            this.Activo = true;
        }

        public void Desactivar()
        {
            this.Activo = false;
        }

        public void Autorizar()
        {
            this.Autorizado = true;
        }

        public void DesAutorizar()
        {
            this.Autorizado = false;
        }
        public void Bloquear()
        {
            this.Bloqueado = true;
        }
        public void DesBloquear()
        {
            this.Bloqueado = false;
        }

        public void Encriptar()
        {
            this.Password = Encriptador.Encriptar(this.password);
        }

        public bool CambiaPassword(string oldPassword, string newPassword)
        {
            string oldPasswordEncriptada = Encriptador.Encriptar(oldPassword);
            string newPasswordEncriptada = Encriptador.Encriptar(newPassword);
            if (oldPasswordEncriptada == this.Password)
            {
                this.Password = newPasswordEncriptada;
                return true;
            }
            return false;
        }
    }
}
