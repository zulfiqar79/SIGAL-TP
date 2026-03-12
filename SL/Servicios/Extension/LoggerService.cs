using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SL.Servicios.Extension
{
    public class LoggerService
    {
        public static void WriteLog(string message)
        {
            BLL.LogBLL.LoggerBLL.WriteLog(message);
        }
    }
}
