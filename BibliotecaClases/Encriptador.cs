using System;

namespace BibliotecaClases
{
    public static class Encriptador
    {
        /// Esta función "encripta" la cadena que le envíamos en el parámentro de entrada.
        public static string Encriptar(string _cadenaAencriptar)
        {
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(_cadenaAencriptar);
            string result = Convert.ToBase64String(encryted);
            return result;
        }

        /// Esta función "desencripta" la cadena que le envíamos en el parámentro de entrada.
        public static string DesEncriptar(string _cadenaAdesencriptar)
        {
            byte[] decryted = Convert.FromBase64String(_cadenaAdesencriptar);
            string result = System.Text.Encoding.Unicode.GetString(decryted);
            return result;
        }
    }
}
