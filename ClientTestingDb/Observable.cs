using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientTestingDb
{
    public abstract class Observable
    {
        private List<IObservateur> ListeObservateur;

        public Observable()
        {
            ListeObservateur = new List<IObservateur>();
        }

        public void AjouterObservateur(IObservateur item)
        {
            ListeObservateur.Add(item);
        }

        public void NotifierObservateur()
        {
            foreach (IObservateur observateur in ListeObservateur)
            {
                observateur.Notifier(this);
            }
        }


    }
}
