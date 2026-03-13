using DAL.DAO;
using Domain;

namespace DAL.AccesoDatos.alquiler
{
    public sealed class PagoDAL
    {
        #region
        private readonly static PagoDAL _instance = new PagoDAL();
        public static PagoDAL Instance { get { return _instance; } }
        private PagoDAL()
        {
        }
        #endregion

        public void Insertar(Pago obj)
        {
            using (base_sigalEntities db = new base_sigalEntities())
            {
                db.Pago.Add(obj);
                db.SaveChanges();
            }
        }
    }
}