namespace BibliotecaClases
{
    public class Validador
    {
        public Validador()
        {
        }

        public bool EmailValido(string email)
        {
            if (email == null || email.Trim().EndsWith("."))
            {
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
