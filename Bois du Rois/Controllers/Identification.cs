using Bois_du_Rois.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Bois_du_Rois;

namespace Bois_du_Rois.Controllers
{
    public class Identification
    {
        private Connection conn;
        private DataTable dtUtilisateur;

        public DataTable GetUtilisateur(TextBox txtLogin, TextBox txtMdp)
        {
            conn = new Connection();
            dtUtilisateur = new DataTable();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT MATRICULE, MDPCOMPTE FROM EMPLOYE WHERE MATRICULE = AND MDPCOMPTE = ;", conn.Connexion))
                {
                    conn.Connexion.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dtUtilisateur.Load(reader);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            return dtUtilisateur;

        }
    }
}
