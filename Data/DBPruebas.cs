using BibliotecaClases;
using Interfaces;
using System.Collections.Generic;

namespace Data
{
    public class DBPruebas : ICapaDatos
    {
        int siguienteIdUsuario = 1;
        int siguienteIdSecreto = 1;
        private SortedList<int, Usuario> tablaUsuarios = new SortedList<int, Usuario>();
        private SortedList<int, Secreto> tablaSecretos = new SortedList<int, Secreto>();

        public DBPruebas()
        {
            // Constructor para cumplimentar los datos iniciales simulados
            // Nuevo usuario Gestor
            Usuario u = new Usuario("gestor@ubusecret.es", "Gestor", "Ubu Secret", "Password");
            this.InsertaUsuario(u);
            u = this.LeeUsuario(u.IdUsuario);
            u.EsGestor = true;
            u.Activar();
            u.CambiaPassword("Password", "P@ssword");
            this.ActualizaUsuario(u);
            // Nuevo usuario básico
            u = new Usuario("user1@ubusecret.es", "usuario", "Basico Uno", "Password");
            this.InsertaUsuario(u);
            u = this.LeeUsuario(u.IdUsuario);
            u.Activar();
            u.CambiaPassword("Password", "U1P@ssword");
            this.ActualizaUsuario(u);
            // Crear secreto
            Secreto s = new Secreto(u, "El primer secreto", "Texto del primer secreto");
            this.InsertaSecreto(s);
        }

        public bool ActualizaSecreto(Secreto _secreto)
        {
            if (tablaSecretos.ContainsKey(_secreto.IdSecreto))
            {
                this.tablaSecretos[_secreto.IdSecreto] = _secreto;
                return true;
            }
            return false;
        }

        public bool ActualizaUsuario(Usuario _usuario)
        {
            if (ExisteUsuarioEmail(_usuario.Email))
            {
                this.tablaUsuarios[_usuario.IdUsuario] = _usuario;
                return true;
            }
            return false;
        }

        public bool BorraSecreto(int _idSecreto)
        {
            if (tablaSecretos.ContainsKey(_idSecreto))
            {
                tablaSecretos.Remove(_idSecreto);
                return true;
            }
            return false;
        }

        public bool BorraSecreto(Secreto _secreto)
        {
            if (tablaSecretos.ContainsKey(_secreto.IdSecreto))
            {
                tablaSecretos.Remove(_secreto.IdSecreto);
                return true;
            }
            return false;
        }

        public bool BorraUsuario(string _email)
        {
            foreach (Usuario usuario in this.tablaUsuarios.Values)
            {
                if (usuario.Email == _email)
                {
                    tablaUsuarios.Remove(usuario.IdUsuario);
                    return true;
                }
            }
            return false;
        }

        public bool BorraUsuario(int _idUsuario)
        {
            if (tablaUsuarios.ContainsKey(_idUsuario))
            {
                tablaUsuarios.Remove(_idUsuario);
                return true;
            }
            return false;
        }

        public bool ExisteUsuarioEmail(string _email)
        {
            foreach (Usuario usuario in this.tablaUsuarios.Values)
            {
                if (usuario.Email == _email)
                {
                    return true;
                }
            }
            return false;
        }

        public bool InsertaSecreto(Secreto _secreto)
        {
            if (tablaSecretos.ContainsKey(_secreto.IdSecreto))
            {
                return false;
            }
            _secreto.IdSecreto = this.siguienteIdSecreto;
            this.siguienteIdSecreto += 1;
            this.tablaSecretos.Add(_secreto.IdSecreto, _secreto);
            return true;
        }

        public bool InsertaUsuario(Usuario _usuario)
        {
            if (tablaUsuarios.ContainsKey(_usuario.IdUsuario))
            {
                return false;
            }
            _usuario.IdUsuario = this.SiguienteUsuario();
            this.siguienteIdUsuario += 1;
            this.tablaUsuarios.Add(_usuario.IdUsuario, _usuario);
            return true;
        }

        public Secreto LeeSecreto(int _idSecreto)
        {
            if (tablaSecretos.ContainsKey(_idSecreto))
            {
                return tablaSecretos[_idSecreto];
            };
            return null;
        }

        public Usuario LeeUsuario(string _email)
        {
            foreach (Usuario usuario in this.tablaUsuarios.Values)
            {
                if (usuario.Email == _email)
                {
                    return usuario;
                }
            }
            return null;
        }

        public Usuario LeeUsuario(int _idUsuario)
        {
            if (tablaUsuarios.ContainsKey(_idUsuario))
            {
                return tablaUsuarios[_idUsuario];
            }
            return null;
        }

        public int NumeroSecretos()
        {
            return this.tablaSecretos.Count;
        }

        public int NumeroUsuarios()
        {
            return this.tablaUsuarios.Count; ;
        }

        public int SiguienteSecreto()
        {
            return this.siguienteIdSecreto;
        }

        public int SiguienteUsuario()
        {
            return this.siguienteIdUsuario;
        }
    }
}