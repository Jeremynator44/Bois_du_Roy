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
    public class Note_De_Frais
    {
        private DataTable dtListeNotes;
        private Connection conn;

        public DataTable GetListeNotes(string matricule)
        {
            conn = new Connection();
            dtListeNotes = new DataTable();

            try
            {
                if (matricule == "")
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT CONCAT(\"Note de Frais de \",PRENOM,\" \", NOM) AS Notes, NOMSTATUT AS Etat, DATENOTEFRAIS AS Dates, CONCAT(COUTTOTAL, \" €\") AS Coût_Total FROM NOTEFRAIS INNER JOIN EMPLOYE ON NOTEFRAIS.MATRICULE = EMPLOYE.MATRICULE INNER JOIN VALIDER ON NOTEFRAIS.IDNOTEFRAIS = VALIDER.IDNOTEFRAIS INNER JOIN ETAPE_VALIDATION ON VALIDER.IDETAPVALID = ETAPE_VALIDATION.IDETAPVALID INNER JOIN STATUT ON ETAPE_VALIDATION.IDSTATUT = STATUT.IDSTATUT INNER JOIN LIGNENOTE ON NOTEFRAIS.IDNOTEFRAIS = LIGNENOTE.IDNOTEFRAIS ORDER BY DATENOTEFRAIS;", conn.Connexion))
                    {
                        conn.Connexion.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        dtListeNotes.Load(reader);
                        reader.Close();
                        conn.Connexion.Close();
                    }
                }
                else
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT CONCAT(\"Note de Frais de \",PRENOM,\" \", NOM) AS Notes, NOMSTATUT AS Etat, DATENOTEFRAIS AS Dates, CONCAT(COUTTOTAL, \" €\") AS Coût_Total \r\nFROM NOTEFRAIS INNER JOIN EMPLOYE ON NOTEFRAIS.MATRICULE = EMPLOYE.MATRICULE \r\nINNER JOIN VALIDER ON NOTEFRAIS.IDNOTEFRAIS = VALIDER.IDNOTEFRAIS \r\nINNER JOIN ETAPE_VALIDATION ON VALIDER.IDETAPVALID = ETAPE_VALIDATION.IDETAPVALID \r\nINNER JOIN STATUT ON ETAPE_VALIDATION.IDSTATUT = STATUT.IDSTATUT \r\nINNER JOIN LIGNENOTE ON NOTEFRAIS.IDNOTEFRAIS = LIGNENOTE.IDNOTEFRAIS WHERE EMPLOYE.MATRICULE = @matricule \r\nORDER BY DATENOTEFRAIS;", conn.Connexion))
                    {
                        cmd.Parameters.AddWithValue("@matricule", matricule);
                        conn.Connexion.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        dtListeNotes.Load(reader);
                        reader.Close();
                        conn.Connexion.Close();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            return dtListeNotes;


        }
    }
}
