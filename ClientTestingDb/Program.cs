using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientTestingDb
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Client client1 = new Client();
            client1.Name = "Louis";
            client1.Type = "normal";
            client1.MtEncours = 2000;
            client1.Save();
            */

            // ACTIVE RECORD
            Client client = Client.CreateObject(TypeClient.NORMAL);

            /*
            // OBSERVER
            ClientObs client = ClientObs.CreateObject(TypeClient.NORMAL);
            client.Name = "John";
            IObservateur observateur = new Trace();
            client.AjouterObservateur(observateur);
            client.Calcul();
            // /OBSERVER
            */
            



        }
    }
}
