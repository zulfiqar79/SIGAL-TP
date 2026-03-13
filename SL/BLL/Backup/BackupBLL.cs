using SL.DAL.BackupDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.BLL
{
    public class BackupBLL
    {
        public void RealizarBackup(string backupPath)
        {
            if (string.IsNullOrWhiteSpace(backupPath))
                throw new Exception("Ruta inválida");

            if (!backupPath.EndsWith(".bak", StringComparison.OrdinalIgnoreCase))
                throw new Exception("El archivo de backup debe tener extensión .bak.");

            BackupDAL dal = new BackupDAL();
            dal.RealizarBackup(backupPath);
        }
    }
}
