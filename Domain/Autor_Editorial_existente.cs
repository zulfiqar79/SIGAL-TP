using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public static class Autor_Editorial_existente
    {
        public static int ID_AUTOR;
        public static string NOMBRE_AUTOR;
        public static string APELLIDO_AUTOR;

        public static int ID_EDITORIAL;
        public static string NOMBRE_EDITORIAL;

        public static bool AutorCargado = false;
        public static bool EditorialCargada = false;
    }
}
