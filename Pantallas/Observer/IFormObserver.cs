using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantallas.Observer
{
    public interface IFormObserver
    {
        void Update(Form form);
        //void OnLanguageChanged(string newLanguage);
    }
}
