using System;

namespace BibliotecaClases
{
    public class Secreto
    {
        private Usuario propietario;
        private string descripcion;
        private string texto;
        private int idSecreto;

        public Secreto(Usuario propietario, string descripcion, string texto)
        {
            this.Propietario = propietario;
            this.Descripcion = descripcion;
            this.Texto = texto;
            this.IdSecreto = -1;
        }

        public Usuario Propietario { get => propietario; set => propietario = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Texto { get => texto; set => texto = value; }
        public int IdSecreto { get => idSecreto; set => idSecreto = value; }

        public override bool Equals(object obj)
        {
            return obj is Secreto secreto &&
                   IdSecreto == secreto.IdSecreto;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(idSecreto);
        }
    }
}
