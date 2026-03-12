using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SL.BLL.LogBLL
{
    internal static class LoggerBLL
    {
        public static void WriteLog(string message)
        {
            DAL.LogDAL.LoggerRepository.Instance.WriteLog(message);
        }
    }
}
