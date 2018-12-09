using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientTestingDb
{
    public abstract class ActiveRecord
    {
        public int Id { get; set; }
        protected DBETAT Etat { get; set; }

        protected abstract void Insert();
        protected abstract void Select(int id);
        protected abstract void Update();
        protected abstract void Delete();

        public ActiveRecord()
        {
            Etat = DBETAT.TOBECREATED;
        }

        public void Load(int id)
        {
            Select(id);
            Etat = DBETAT.NONE;
        }

        public void PrepareToDelete()
        {
            Etat = DBETAT.TOBEDELETED;
        }
        public void Save()
        {
            switch (Etat)
            {
                case DBETAT.TOBECREATED:
                    Insert();
                    Etat=DBETAT.NONE;
                    break;
                case DBETAT.TOBEUPDATED:
                    Update();
                    Etat = DBETAT.NONE;
                    break;
                case DBETAT.TOBEDELETED:
                    Delete();
                    break;
            }
        }

        protected void Change()
        {
            if (Etat == DBETAT.NONE)
            {
                Etat = DBETAT.TOBEUPDATED;
            }
        }

    }

    public enum DBETAT
    {
        NONE,
        TOBECREATED,
        TOBEUPDATED,
        TOBEDELETED
    }
}
