using System.Collections.Generic;

namespace Domain.Composite
{
    /// <summary>
    /// Interfaz del patrón Composite para el modelo de permisos.
    /// Permite tratar Patentes individuales y Familias de permisos de forma uniforme.
    /// </summary>
    public interface IComponentePermiso
    {
        /// <summary>Nombre descriptivo del componente.</summary>
        string Nombre { get; }

        /// <summary>
        /// Verifica si este componente otorga el permiso con el nombre indicado.
        /// Una Familia delega la verificación a sus hijos.
        /// </summary>
        bool TienePermiso(string nombre);

        /// <summary>
        /// Devuelve todos los IDs de permiso (ID_PERMISO) que componen este componente.
        /// </summary>
        IEnumerable<int> ObtenerIds();
    }
}
