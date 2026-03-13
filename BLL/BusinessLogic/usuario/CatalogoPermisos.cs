using Domain.Composite;

namespace BLL.BusinessLogic.usuario
{
    /// <summary>
    /// Catálogo centralizado de Patentes y Familias de permisos del sistema.
    /// Define los permisos conocidos y sus agrupaciones predefinidas,
    /// alineados con los IDs de la tabla Permiso (IDs 13-16).
    /// </summary>
    public static class CatalogoPermisos
    {
        // --- Patentes individuales ---

        /// <summary>Permiso de Gestión de Alquiler (ID_PERMISO = 13).</summary>
        public static readonly Patente Alquiler = new Patente(13, "Alquiler");

        /// <summary>Permiso de Gestión de Libro (ID_PERMISO = 14).</summary>
        public static readonly Patente Libro = new Patente(14, "Libro");

        /// <summary>Permiso de Gestión de Cliente (ID_PERMISO = 15).</summary>
        public static readonly Patente Cliente = new Patente(15, "Cliente");

        /// <summary>Permiso de Gestión de Usuario (ID_PERMISO = 16).</summary>
        public static readonly Patente Usuario = new Patente(16, "Usuario");

        // --- Familias predefinidas ---

        /// <summary>
        /// Familia operativa: agrupa Alquiler y Libro.
        /// Representa el perfil de un operador de biblioteca.
        /// </summary>
        public static readonly FamiliaPermiso GestionOperativa;

        /// <summary>
        /// Familia administrativa: agrupa Cliente y Usuario.
        /// Representa el perfil de un administrador de cuentas.
        /// </summary>
        public static readonly FamiliaPermiso GestionAdministrativa;

        /// <summary>
        /// Familia de acceso total: incluye todas las patentes del sistema.
        /// Representa el perfil de administrador completo.
        /// </summary>
        public static readonly FamiliaPermiso AccesoTotal;

        static CatalogoPermisos()
        {
            GestionOperativa = new FamiliaPermiso("GestionOperativa");
            GestionOperativa.Agregar(Alquiler);
            GestionOperativa.Agregar(Libro);

            GestionAdministrativa = new FamiliaPermiso("GestionAdministrativa");
            GestionAdministrativa.Agregar(Cliente);
            GestionAdministrativa.Agregar(Usuario);

            AccesoTotal = new FamiliaPermiso("AccesoTotal");
            AccesoTotal.Agregar(GestionOperativa);
            AccesoTotal.Agregar(GestionAdministrativa);
        }

        /// <summary>
        /// Obtiene la Patente que corresponde a un ID_PERMISO dado.
        /// Retorna null si el ID no corresponde a ninguna patente conocida.
        /// </summary>
        public static Patente ObtenerPatente(int idPermiso)
        {
            if (idPermiso == Alquiler.IdPermiso) return Alquiler;
            if (idPermiso == Libro.IdPermiso) return Libro;
            if (idPermiso == Cliente.IdPermiso) return Cliente;
            if (idPermiso == Usuario.IdPermiso) return Usuario;
            return null;
        }
    }
}
