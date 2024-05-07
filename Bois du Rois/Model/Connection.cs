using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bois_du_Rois;
using MySql.Data.MySqlClient;
using Mysqlx.Connection;

namespace Bois_du_Rois.Model
{
    public class Connection
    {
        private MySqlConnection connexion;
        private string server = "192.168.151.6";
        private string database = "boisduroy";
        private string uid = "jloubeyre";
        private string password = "rI1tbBqD";

    public MySqlConnection Connexion
    {
        get { return connexion; }
        set { connexion = value; }
    }

    public Connection()
    {
        Initialise();
    }

    private void Initialise()
    {
        string connectionString;
        connectionString = "SERVER=" + server + ";" + "DATABASE=" +
        database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
        

        connexion = new MySqlConnection(connectionString);
    }

    public Connection(string leServeur, string laDatabase, string leUid, string lePassword)
    {

        server = leServeur;
        database = laDatabase;
        uid = leUid;
        password = lePassword;
        Initialise();
    }
}
    

}
