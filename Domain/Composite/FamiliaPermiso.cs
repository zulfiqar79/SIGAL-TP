using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Composite
{
    /// <summary>
    /// Nodo compuesto del patrón Composite: representa una familia de permisos.
    /// Puede contener Patentes individuales u otras Familias anidadas.
    /// Corresponde a un registro de la tabla Permiso con TIPO_PERMISO = 'FAMILIA'.
    /// </summary>
    public class FamiliaPermiso : IComponentePermiso
    {
        private readonly List<IComponentePermiso> _componentes = new List<IComponentePermiso>();

        public string Nombre { get; }

        public FamiliaPermiso(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre de la familia no puede estar vacío.", nameof(nombre));

            Nombre = nombre;
        }

        /// <summary>Agrega un componente (Patente o Familia) a esta familia.</summary>
        public void Agregar(IComponentePermiso componente)
        {
            if (componente == null)
                throw new ArgumentNullException(nameof(componente));

            _componentes.Add(componente);
        }

        /// <summary>Elimina un componente de esta familia.</summary>
        public void Eliminar(IComponentePermiso componente)
        {
            _componentes.Remove(componente);
        }

        /// <summary>Devuelve los componentes hijos de esta familia.</summary>
        public IReadOnlyList<IComponentePermiso> ObtenerComponentes()
        {
            return _componentes.AsReadOnly();
        }

        /// <summary>
        /// Retorna true si la familia misma o alguno de sus hijos posee el permiso indicado.
        /// </summary>
        public bool TienePermiso(string nombre)
        {
            if (string.Equals(Nombre, nombre, StringComparison.OrdinalIgnoreCase))
                return true;

            return _componentes.Any(c => c.TienePermiso(nombre));
        }

        /// <summary>Devuelve todos los IDs de permiso de todos los hijos, sin duplicados.</summary>
        public IEnumerable<int> ObtenerIds()
        {
            return _componentes.SelectMany(c => c.ObtenerIds()).Distinct();
        }

        public override string ToString()
        {
            return string.Format("Familia({0}: [{1}])", Nombre,
                string.Join(", ", _componentes.Select(c => c.Nombre)));
        }
    }
}
