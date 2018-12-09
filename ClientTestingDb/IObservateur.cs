using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientTestingDb
{
    public interface IObservateur
    {
        void Notifier(Observable obj);
    }
}
