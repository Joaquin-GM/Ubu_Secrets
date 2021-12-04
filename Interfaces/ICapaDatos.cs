using Biblioteca_Clases;
using System;

namespace Interfaces
{
    public interface ICapaDatos
    {
        // Método que devuelve el número de usuarios registrados en la aplicación
        int NumeroUsuarios();

        // Método que devuelve el número de secretos registrados en la aplicación
        int NumeroSecretos();

        // Método que devuelve el identificador que se asignara al siguiente usuario que se agregue.
        int SiguienteUsuario();

        // Método que devuelve el identificador que se asignara al siguiente secreto que se agregue.
        int SiguienteSecreto();

        // Método que elimina el usuario que tenga el EMail proporcionado como parámetro.
        // Retorna:
        // Verdadero si lo borra
        // Falso si no existe en la base de datos
        bool BorraUsuario(string _cuenta);

        // Método que elimina el usuario que tenga el Identificador (int) proporcionado como parámetro.
        // Retorna:
        // Verdadero si lo borra
        // Falso si no existe en la base de datos
        bool BorraUsuario(int _identificador);

        // Método que inserta el objeto de la clase Usuario proporcionado como parámetro.
        // Retorna:
        // Verdadero si lo inserta correctamente
        // Falso si no lo logra porque ya existe uno con ese EMail
        bool InsertaUsuario(Usuario _usuario);

        // Método que devuelve si existe un usuario con un email dado.
        // Retorna:
        // Verdadero si existe
        // Falso si no existe ninguno en la base de datos con ese email
        bool ExisteUsuarioEmail(String _email);

        // Método que devuelve el usuario asociado a un email dado.
        // Retorna:
        // Usuario si existe
        // Null si no existe ninguno en la base de datos con ese email
        Usuario LeeUsuario(String _email);

        // Método que devuelve el usuario asociado a un id dado.
        // Retorna:
        // Usuario si existe
        // Null si no existe ninguno en la base de datos con ese id
        Usuario LeeUsuario(int _idUsuario);

        // Método que actualiza el usuario pasado como proporcionado como parámetro.
        // Retorna:
        // Verdadero si lo actualiza
        // Falso si no existe en la base de datos
        bool ActualizaUsuario(Usuario _usuario);

        // Método que inserta el objeto de la clase Secreto proporcionado como parámetro.
        // Retorna:
        // Secreto si lo inserta correctamente
        // Null si no lo logra porque ya existe un secreto igual.
        bool InsertaSecreto(Secreto _secreto);

        // Método que elimina el secreto que tenga el Identificador (int) proporcionado como parámetro.
        // Retorna:
        // Verdadero si lo borra
        // Falso si no existe en la base de datos
        bool BorraSecreto(int _idSecreto);

        // Método que elimina el secreto pasado como proporcionado como parámetro.
        // Retorna:
        // Verdadero si lo borra
        // Falso si no existe en la base de datos
        bool BorraSecreto(Secreto _secreto);

        // Método que actualiza el secreto pasado como proporcionado como parámetro.
        // Retorna:
        // Verdadero si lo actualiza
        // Falso si no existe en la base de datos
        bool ActualizaSecreto(Secreto _secreto);

        // Método que devuelve el secreto asociado a un secreto encriptado dado.
        // Retorna:
        // Texto del secreto si existe
        // Null si no existe ninguno en la base de datos con ese email
        Secreto LeeSecreto(String _secretoEncriptado);

        // Método que devuelve el secreto asociado a un id dado.
        // Retorna:
        // Secreto si existe
        // Null si no existe ninguno secreto en la base de datos con ese id
        Secreto LeeSecreto(int _idSecreto);
    }
}
