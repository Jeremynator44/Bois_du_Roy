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
    public class ListeEmployés
    {
        private DataTable dtListeEmployés;
        private Connection conn;

        public DataTable GetListeEmployés()
        {
            conn = new Connection();
            dtListeEmployés = new DataTable();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT EMPLOYE.MATRICULE AS Matricule, EMPLOYE.NOM AS Nom, EMPLOYE.PRENOM AS Prénom, TYPEPRODUIT.TYPEPRODUIT AS \"Type Produit\", EMPLOYE.DATENAISS AS \"Date de Naissance\", EMPLOYE.DATEENTREE AS \"Date Entrée\", EMPLOYE.DATESORTIE AS \"Date Sortie\", EMPLOYE.MATRICULE_ETRE_RESPONSABLE AS Responsable FROM EMPLOYE INNER JOIN TYPEPRODUIT ON EMPLOYE.CODEPRODUIT = TYPEPRODUIT.CODEPRODUIT ORDER BY EMPLOYE.NOM;", conn.Connexion))
                {
                    conn.Connexion.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dtListeEmployés.Load(reader);
                    reader.Close();
                    conn.Connexion.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            return dtListeEmployés;


        }

    }
}
