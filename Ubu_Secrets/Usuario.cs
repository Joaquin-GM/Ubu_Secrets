using System;

namespace Biblioteca_Clases
{
    public class Usuario
    {
        private String idUsuario;
        private String nombre;
        private String apellidos;
        private String email;
        private String password;
        private String ultimaIp;
        private DateTime ultimaActividad;
        private bool esGestor;
        private bool activo;
        private bool autorizado;
        private bool bloqueado;

        public Usuario(string idUsuario, string nombre, string apellidos, string email, bool esGestor, bool estado, string password, DateTime ultimaActividad, string ultimaIp)
        {
            this.idUsuario = idUsuario;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.email = email;
            this.esGestor = esGestor;
            this.password = password;
            this.ultimaActividad = ultimaActividad;
            this.ultimaIp = ultimaIp;
        }

        public string IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public DateTime UltimaActividad { get => ultimaActividad; set => ultimaActividad = value; }
        public string UltimaIp { get => ultimaIp; set => ultimaIp = value; }
        public bool Activo { get => activo; set => activo = value; }
        public bool EsGestor { get => esGestor; set => esGestor = value; }
        public bool Activo1 { get => activo; set => activo = value; }
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

        public void Activar(Usuario _usuario)
        {
            _usuario.Activo = true;
        }

        public void Desactivar(Usuario _usuario)
        {
            _usuario.Activo = false;
        }

        public void Autorizar(Usuario _usuario)
        {
            _usuario.Autorizado = true;
        }

        public void DesAutorizar(Usuario _usuario)
        {
            _usuario.Autorizado = false;
        }
        public void Bloquear(Usuario _usuario)
        {
            _usuario.Bloqueado = true;
        }
        public void DesBloquear(Usuario _usuario)
        {
            _usuario.Bloqueado = false;
        }
    }
}
