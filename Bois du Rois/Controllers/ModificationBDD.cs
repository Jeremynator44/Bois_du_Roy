using Bois_du_Rois.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using BC = BCrypt.Net.BCrypt;
using System.Net;
using Org.BouncyCastle.Crypto.Macs;
using Mysqlx.Crud;

namespace Bois_du_Rois.Controllers
{
    public class ModificationBDD
    {
        private Connection conn;

        public void AjoutNoteDeFraisBDD(string matricule, string date, double couttotal, int idnote, int quantite_frais_kilometrique, double cout_frais_kilometrique, int quantite_repas_midi, double cout_repas_midi, int quantite_repas_soir, double cout_repas_soir, int quantite_soir_hors_paris, double cout_soir_hors_paris, int quantite_soir_paris, double cout_soir_paris)
        {


            //"INSERT INTO NOTEFRAIS(MATRICULE, DATENOTEFRAIS, LIBELLENOTEFRAIS, COUTTOTAL) VALUES(@matricule, @date, "", @couttotal);";
            //"INSERT INTO LIGNENOTE(IDNOTEFRAIS, IDLIGNENOTE, IDTYPEFRAIS, QUANTITE, COUT) VALUES(@idnote, 1, 1, @quantite_frais_kilometrique, @cout_frais_kilometrique);";
            //"INSERT INTO LIGNENOTE(IDNOTEFRAIS, IDLIGNENOTE, IDTYPEFRAIS, QUANTITE, COUT) VALUES(@idnote, 2, 2, @quantite_repas_midi, @cout_repas_midi);";
            //"INSERT INTO LIGNENOTE(IDNOTEFRAIS, IDLIGNENOTE, IDTYPEFRAIS, QUANTITE, COUT) VALUES(@idnote, 3, 3, @quantite_repas_soir, @cout_repas_soir);";
            //"INSERT INTO LIGNENOTE(IDNOTEFRAIS, IDLIGNENOTE, IDTYPEFRAIS, QUANTITE, COUT) VALUES(@idnote, 4, 4, @quantite_soir_hors_paris, @cout_soir_hors_paris);";
            //"INSERT INTO LIGNENOTE(IDNOTEFRAIS, IDLIGNENOTE, IDTYPEFRAIS, QUANTITE, COUT) VALUES(@idnote, 5, 5, @quantite_soir_paris, @cout_soir_paris);";

            conn = new Connection();
            string rqtSql = "INSERT INTO NOTEFRAIS(MATRICULE, DATENOTEFRAIS, LIBELLENOTEFRAIS, COUTTOTAL) VALUES(@matricule, @date, '', @couttotal);";
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(rqtSql, conn.Connexion))
                {
                    cmd.Parameters.AddWithValue("@matricule", matricule);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@couttotal", couttotal);

                    conn.Connexion.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    reader.Close();
                    conn.Connexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }

            rqtSql = "INSERT INTO LIGNENOTE(IDNOTEFRAIS, IDLIGNENOTE, IDTYPEFRAIS, QUANTITE, COUT) VALUES(@idnote, 1, 1, @quantite_frais_kilometrique, @cout_frais_kilometrique);";
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(rqtSql, conn.Connexion))
                {
                    cmd.Parameters.AddWithValue("@idnote", idnote);
                    cmd.Parameters.AddWithValue("@quantite_frais_kilometrique", quantite_frais_kilometrique);
                    cmd.Parameters.AddWithValue("@cout_frais_kilometrique", cout_frais_kilometrique);

                    conn.Connexion.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    reader.Close();
                    conn.Connexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }

            rqtSql = "INSERT INTO LIGNENOTE(IDNOTEFRAIS, IDLIGNENOTE, IDTYPEFRAIS, QUANTITE, COUT) VALUES(@idnote, 2, 2, @quantite_repas_midi, @quantite_repas_midi);";
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(rqtSql, conn.Connexion))
                {
                    cmd.Parameters.AddWithValue("@idnote", idnote);
                    cmd.Parameters.AddWithValue("@quantite_repas_midi", quantite_repas_midi);
                    cmd.Parameters.AddWithValue("@cout_repas_midi", cout_repas_midi);

                    conn.Connexion.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    reader.Close();
                    conn.Connexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }

            rqtSql = "INSERT INTO LIGNENOTE(IDNOTEFRAIS, IDLIGNENOTE, IDTYPEFRAIS, QUANTITE, COUT) VALUES(@idnote, 3, 3, @quantite_repas_soir, @cout_repas_soir);";
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(rqtSql, conn.Connexion))
                {
                    cmd.Parameters.AddWithValue("@idnote", idnote);
                    cmd.Parameters.AddWithValue("@quantite_repas_soir", quantite_repas_soir);
                    cmd.Parameters.AddWithValue("@cout_repas_soir", cout_repas_soir);

                    conn.Connexion.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    reader.Close();
                    conn.Connexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }

            rqtSql = "INSERT INTO LIGNENOTE(IDNOTEFRAIS, IDLIGNENOTE, IDTYPEFRAIS, QUANTITE, COUT) VALUES(@idnote, 4, 4, @quantite_soir_hors_paris, @cout_soir_hors_paris);";
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(rqtSql, conn.Connexion))
                {
                    cmd.Parameters.AddWithValue("@idnote", idnote);
                    cmd.Parameters.AddWithValue("@quantite_soir_hors_paris", quantite_soir_hors_paris);
                    cmd.Parameters.AddWithValue("@cout_soir_hors_paris", cout_soir_hors_paris);

                    conn.Connexion.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    reader.Close();
                    conn.Connexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }

            rqtSql = "INSERT INTO LIGNENOTE(IDNOTEFRAIS, IDLIGNENOTE, IDTYPEFRAIS, QUANTITE, COUT) VALUES(@idnote, 5, 5, @quantite_soir_paris, @cout_soir_paris);";
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(rqtSql, conn.Connexion))
                {
                    cmd.Parameters.AddWithValue("@idnote", idnote);
                    cmd.Parameters.AddWithValue("@quantite_soir_paris", quantite_soir_paris);
                    cmd.Parameters.AddWithValue("@cout_soir_paris", cout_soir_paris);

                    conn.Connexion.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    reader.Close();
                    conn.Connexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
        }



        public double GetCoutBDD(string typefrais, double valeur)
        {
            conn = new Connection();

            string rqtSql = "SELECT REMBOURSEMENTTYPEFRAIS FROM TYPEFRAIS";
            rqtSql += " WHERE TYPEFRAIS = @typefrais;";
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(rqtSql, conn.Connexion))
                {
                    cmd.Parameters.AddWithValue("@typefrais", typefrais);
                    conn.Connexion.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        valeur = Convert.ToDouble(reader["REMBOURSEMENTTYPEFRAIS"]);
                    }

                    reader.Close();
                    conn.Connexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }

            return valeur;
        }


        public int GetIdBDD(int valeur)
        {
            conn = new Connection();

            string rqtSql = "SELECT IDNOTEFRAIS FROM NOTEFRAIS ";
            rqtSql += " ORDER BY NOTEFRAIS.IDNOTEFRAIS DESC;";
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(rqtSql, conn.Connexion))
                {
                    conn.Connexion.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        valeur = Convert.ToInt32(reader[0]);
                        MessageBox.Show("valeur = " + valeur, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    reader.Close();
                    conn.Connexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }

            return valeur;
        }
    }
}

