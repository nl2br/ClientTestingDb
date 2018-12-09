using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientTestingDb
{
 
    public abstract class ClientObs : Observable
    {

        public int Id { get; set; }
        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        private TypeClient _Type;
        public TypeClient Type
        {
            get { return _Type; }
            set { _Type = value; }
        }

        private int _MtEncours;
        public int MtEncours
        {
            get { return _MtEncours; }
            set { _MtEncours = value; }
        }

        public ClientObs(TypeClient type)
        {
            Type = type;
        }

        public static ClientObs CreateObject(TypeClient type)
        {
            ClientObs obj = null;

            switch (type)
            {
                case TypeClient.NORMAL:
                    obj = new ClientNormal();
                    break;
                case TypeClient.PREMIUM:
                    obj = new ClientPremium();
                    break;
                case TypeClient.ASURVEILLER:
                    obj = new ClientAsurveiller();
                    break;
                default:
                    break;
            }

            return obj;
        }


        protected class ClientNormal : ClientObs
        {
            internal ClientNormal() : base(TypeClient.NORMAL)
            {

            }
        }

        protected class ClientPremium : ClientObs
        {
            internal ClientPremium() : base(TypeClient.PREMIUM)
            {

            }
        }

        protected class ClientAsurveiller : ClientObs
        {
            internal ClientAsurveiller() : base(TypeClient.ASURVEILLER)
            {

            }
        }

        public int Calcul()
        {

            NotifierObservateur();
            return 1 + 1;
        }

        public static List<ClientObs> GetList()
        {
            List<ClientObs> listeClient = new List<ClientObs>();
            SqlConnection oConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\marilou\Documents\mdsb3.mdf;Integrated Security=True;Connect Timeout=30");
            oConn.Open();

            SqlCommand oCmd = oConn.CreateCommand();
            oCmd.CommandText = "SELECT * FROM CLIENT";

            // notre objet contient le resultat de la req
            SqlDataReader oReader = oCmd.ExecuteReader();

            while (oReader.Read())
            {
                var client = ClientObs.CreateObject(TypeClient.NORMAL);
                client.Id = Convert.ToInt32(oReader["Id"]);
                client.Name = Convert.ToString(oReader["NOM"]);
                //client.Type = Convert.ToString(oReader["TYPE"]);
                client.MtEncours = Convert.ToInt32(oReader["MtEnCours"]);
                listeClient.Add(client);
            }

            oReader.Close();
            oConn.Close();

            return listeClient;

        }

        protected  void Insert()
        {
            //on créer la connection
            SqlConnection oConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\marilou\Documents\mdsb3.mdf;Integrated Security=True;Connect Timeout=30");
            oConn.Open();

            // on creer la requete
            SqlCommand oCmd = oConn.CreateCommand();
            oCmd.CommandText =
                "INSERT INTO CLIENT (NOM,TYPE,MTENCOURS) " +
                "VALUES (@NOM, @TYPE, @MTENCOURS)";

            // whith parameters
            oCmd.Parameters.AddWithValue("@NOM", this.Name);
            oCmd.Parameters.AddWithValue("@TYPE", this.Type);
            oCmd.Parameters.AddWithValue("@MTENCOURS", this.MtEncours);

            // on execute la req
            oCmd.ExecuteNonQuery();

            oConn.Close();
        }

        protected  void Select(int id)
        {
            //on créer la connection
            SqlConnection oConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\marilou\Documents\mdsb3.mdf;Integrated Security=True;Connect Timeout=30");
            oConn.Open();

            // on creer la requete
            SqlCommand oCmd = oConn.CreateCommand();
            oCmd.CommandText = "SELECT * FROM CLIENT WHERE Id=@ID";

            // whith parameters
            oCmd.Parameters.AddWithValue("@ID", id);

            // notre objet contient le resultat de la req
            SqlDataReader oReader = oCmd.ExecuteReader();

            oReader.Read();

            if (oReader.HasRows)
            {
                this.Id = Convert.ToInt32(oReader["Id"]);
                this.Name = Convert.ToString(oReader["NOM"]);
                //this.Type = Convert.ToString(oReader["TYPE"]);
                this.MtEncours = Convert.ToInt32(oReader["MTENCOURS"]);
            }
            else
            {
                this.Id = -1;
            }

            oReader.Close();
            oConn.Close();
        }

        protected  void Update()
        {
            //on créer la connection
            SqlConnection oConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\marilou\Documents\mdsb3.mdf;Integrated Security=True;Connect Timeout=30");
            oConn.Open();

            // on creer la requete
            SqlCommand oCmd = oConn.CreateCommand();
            oCmd.CommandText =
                "UPDATE CLIENT SET " +
                "NOM = @NOM, " +
                "TYPE = @TYPE," +
                "MTENCOURS = @MTENCOURS " +
                "WHERE ID = @ID";

            // whith parameters
            oCmd.Parameters.AddWithValue("@NOM", this.Name);
            oCmd.Parameters.AddWithValue("@TYPE", this.Type);
            oCmd.Parameters.AddWithValue("@MTENCOURS", this.MtEncours);
            oCmd.Parameters.AddWithValue("@ID", this.Id);

            // on execute la req
            oCmd.ExecuteNonQuery();

            oConn.Close();
        }

        protected  void Delete()
        {
            //on créer la connection
            SqlConnection oConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\marilou\Documents\mdsb3.mdf;Integrated Security=True;Connect Timeout=30");
            oConn.Open();

            // on creer la requete
            SqlCommand oCmd = oConn.CreateCommand();
            oCmd.CommandText =
                "DELETE FROM CLIENT " +
                "WHERE Id = @ID";

            // whith parameters
            oCmd.Parameters.AddWithValue("@ID", this.Id);

            // on execute la req
            oCmd.ExecuteNonQuery();

            oConn.Close();
        }
    }
}
