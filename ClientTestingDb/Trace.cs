using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientTestingDb
{
    public class Trace : IObservateur
    {
        public void Notifier(Observable obj)
        {
            ClientObs client = (ClientObs)obj;
            Console.WriteLine("calcul de {0} à {1}", client.Name, DateTime.Now);
        }
    }
}
