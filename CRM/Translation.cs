using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CRM
{
    public class Translation
    {
        private string userCultureInfo;
        public string GetIncorrectLogin()
        {
            if (this.userCultureInfo == "es-ES")
            {
                return "usuario o contraseña invalido";
            }
            else
            {
                return "Invalid username or password";
            }
        }

        public Translation()
        {
            this.userCultureInfo = System.Globalization.CultureInfo.CurrentCulture.ToString();
        }
        public string GetInvalidTime()
        {
            if (this.userCultureInfo == "es-ES")
            {
                return "La hora de inicio está fuera del horario comercial(7 am - 6pm)";
            }
            else
            {
                return "Start time is outside of buisiness hours (7am-6pm)";
            }
        }
        public string GetUserLabelTranslation()
        {
            if (this.userCultureInfo == "es-ES")
            {
                return "nombre de usuario";
            }
            else
            {
                return "Username";
            }
        }
        public string GetPasswordLabelTranslation()
        {
            if (this.userCultureInfo == "es-ES")
            {
                return "contraseña";
            }
            else
            {
                return "Password";
            }
        }
        public string GetLoginTranslation()
        {
            if (this.userCultureInfo == "es-ES")
            {
                return "iniciar sesión";
            }
            else
            {
                return "Login";
            }
        }
    }
}
