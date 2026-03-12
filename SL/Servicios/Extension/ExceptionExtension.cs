using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Servicios.Extension
{
    public static class ExceptionExtension
    {
        public static void Handle(this Exception ex, object sender)
        {
            BLL.ExceptionBLL.Exception_BLL.Handle(ex, sender);
        }
    }
}
