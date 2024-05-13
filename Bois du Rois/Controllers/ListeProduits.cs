using Bois_du_Rois.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Bois_du_Rois.Controllers
{
    public class ListeProduits
    {
        private DataTable dtListeProduits;
        private Connection conn;

        public DataTable GetListeProduits()
        {
            conn = new Connection();
            dtListeProduits = new DataTable();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT CODEPRODUIT AS \"Code Produit\", TYPEPRODUIT AS \"Type Produit\" FROM TYPEPRODUIT ORDER BY CODEPRODUIT;", conn.Connexion))
                {
                    conn.Connexion.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dtListeProduits.Load(reader);
                    reader.Close();
                    conn.Connexion.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            return dtListeProduits;


        }

    }
}
