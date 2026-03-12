using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SL.Correo
{
    public static class ValidarCorreo
    {
        public static string Validar(string correo)
        {
            string patron = @"^[a-zA-Z0-9._%+-]+@(hotmail\.com|gmail\.com)$";
            string valido = "true";
            if (Regex.IsMatch(correo, patron))
            {
                valido = "true";
                return valido;
            }
            else
            {
                valido = "false";
                return valido;
            }
        }
    }
}
