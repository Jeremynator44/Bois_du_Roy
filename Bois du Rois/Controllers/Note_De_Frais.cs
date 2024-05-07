using Bois_du_Rois.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Bois_du_Rois.Model;

namespace Bois_du_Rois.Controllers
{
    public class Note_De_Frais
    {
        private DataTable dtListeNotes;
        private Connection conn;


        public DataTable GetListeNotes()
        {
            conn = new Connection();
            dtListeNotes = new DataTable();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT CONCAT(\"Note de Frais de \",PRENOM,\" \", NOM) AS Notes, NOMSTATUT AS Etat, DATENOTEFRAIS AS Dates, CONCAT(COUTTOTAL, \" €\") AS Coût_Total \r\nFROM NOTEFRAIS INNER JOIN EMPLOYE ON NOTEFRAIS.MATRICULE = EMPLOYE.MATRICULE \r\nINNER JOIN VALIDER ON NOTEFRAIS.IDNOTEFRAIS = VALIDER.IDNOTEFRAIS \r\nINNER JOIN ETAPE_VALIDATION ON VALIDER.IDETAPVALID = ETAPE_VALIDATION.IDETAPVALID \r\nINNER JOIN STATUT ON ETAPE_VALIDATION.IDSTATUT = STATUT.IDSTATUT \r\nINNER JOIN LIGNENOTE ON NOTEFRAIS.IDNOTEFRAIS = LIGNENOTE.IDNOTEFRAIS \r\nORDER BY DATENOTEFRAIS;", conn.Connexion))
                {
                    conn.Connexion.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dtListeNotes.Load(reader);

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            return dtListeNotes;


        }
    }
}
