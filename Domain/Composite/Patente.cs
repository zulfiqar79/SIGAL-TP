using System;
using System.Collections.Generic;

namespace Domain.Composite
{
    /// <summary>
    /// Hoja del patrón Composite: representa un permiso individual (Patente).
    /// Corresponde a un registro de la tabla Permiso con TIPO_PERMISO = 'PATENTE'.
    /// </summary>
    public class Patente : IComponentePermiso
    {
        public int IdPermiso { get; }
        public string Nombre { get; }

        public Patente(int idPermiso, string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre de la patente no puede estar vacío.", nameof(nombre));

            IdPermiso = idPermiso;
            Nombre = nombre;
        }

        /// <summary>Retorna true si el nombre coincide con el de esta patente.</summary>
        public bool TienePermiso(string nombre)
        {
            return string.Equals(Nombre, nombre, StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>Retorna una colección con el único ID de esta patente.</summary>
        public IEnumerable<int> ObtenerIds()
        {
            return new[] { IdPermiso };
        }

        public override string ToString()
        {
            return string.Format("Patente({0}: {1})", IdPermiso, Nombre);
        }
    }
}
