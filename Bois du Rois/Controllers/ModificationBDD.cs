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
using Org.BouncyCastle.Asn1.X9;

namespace Bois_du_Rois.Controllers
{
    public class ModificationBDD
    {
        private Connection conn;

        public void AjoutNoteDeFraisBDD(string matricule, string date, double couttotal, int idnote, decimal quantite_frais_kilometrique, double cout_frais_kilometrique, decimal quantite_repas_midi, double cout_repas_midi, decimal quantite_repas_soir, double cout_repas_soir, decimal quantite_soir_hors_paris, double cout_soir_hors_paris, decimal quantite_soir_paris, double cout_soir_paris)
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
                    
                }
            }
            catch (Exception ex)
            {
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

                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Close();
                    
                }
            }
            catch (Exception ex)
            {
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

                    
                    MySqlDataReader reader = cmd.ExecuteReader();

                    reader.Close();
                    
                }
            }
            catch (Exception ex)
            {
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

                    MySqlDataReader reader = cmd.ExecuteReader();

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
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

                    MySqlDataReader reader = cmd.ExecuteReader();

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
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

                    MySqlDataReader reader = cmd.ExecuteReader();

                    reader.Close();
                    conn.Connexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
        }





        public double GetCoutBDD(string typefrais, decimal quantite ,double cout)
        {
            conn = new Connection();
            double valeur_cout = 0;

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
                        valeur_cout = Convert.ToDouble(reader["REMBOURSEMENTTYPEFRAIS"]);
                    }

                    reader.Close();
                    conn.Connexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }

            cout = Convert.ToDouble(quantite) * valeur_cout;
            return cout;
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
                    reader.Read();

                    valeur = Convert.ToInt32(reader[0]);

                    reader.Close();
                    conn.Connexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }

            return valeur;
        }

        public void UpdateMDPBDD(string mdp, string matricule)
        {
            conn = new Connection();

            string rqtSql = "UPDATE EMPLOYE SET MDPCOMPTE = @mdp WHERE MATRICULE = @matricule;";
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(rqtSql, conn.Connexion))
                {
                    cmd.Parameters.AddWithValue("@mdp", mdp);
                    cmd.Parameters.AddWithValue("@matricule", matricule);

                    conn.Connexion.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Close();
                    conn.Connexion.Close();
                    MessageBox.Show("L'attribution du mot de passe a été un succès !!", "Erreur", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
        }
        public void UpdateEmployéBDD(string matricule, string var, string txt)
        {
            conn = new Connection();

            if (var == "NOM")
            {
                string rqtSql = "UPDATE EMPLOYE SET NOM = @txt WHERE MATRICULE = @matricule;";
                try
                {
                    using (MySqlCommand cmd = new MySqlCommand(rqtSql, conn.Connexion))
                    {
                        cmd.Parameters.AddWithValue("@matricule", matricule);
                        cmd.Parameters.AddWithValue("@txt", txt);

                        conn.Connexion.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        reader.Close();
                        conn.Connexion.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
            }
            else if (var == "PRENOM")
            {
                string rqtSql = "UPDATE EMPLOYE SET PRENOM = @txt WHERE MATRICULE = @matricule;";
                try
                {
                    using (MySqlCommand cmd = new MySqlCommand(rqtSql, conn.Connexion))
                    {
                        cmd.Parameters.AddWithValue("@matricule", matricule);
                        cmd.Parameters.AddWithValue("@txt", txt);

                        conn.Connexion.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        reader.Close();
                        conn.Connexion.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
            }
            else if (var == "DATENAISS")
            {
                string rqtSql = "UPDATE EMPLOYE SET DATENAISS = @txt WHERE MATRICULE = @matricule;";
                try
                {
                    using (MySqlCommand cmd = new MySqlCommand(rqtSql, conn.Connexion))
                    {
                        cmd.Parameters.AddWithValue("@matricule", matricule);
                        cmd.Parameters.AddWithValue("@txt", txt);

                        conn.Connexion.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        reader.Close();
                        conn.Connexion.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
            }
            else if (var == "DATEENTREE")
            {
                string rqtSql = "UPDATE EMPLOYE SET DATEENTREE = @txt WHERE MATRICULE = @matricule;";
                try
                {
                    using (MySqlCommand cmd = new MySqlCommand(rqtSql, conn.Connexion))
                    {
                        cmd.Parameters.AddWithValue("@matricule", matricule);
                        cmd.Parameters.AddWithValue("@txt", txt);

                        conn.Connexion.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        reader.Close();
                        conn.Connexion.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
            }
            else if (var == "DATESORTIE")
            {
                string rqtSql = "UPDATE EMPLOYE SET DATESORTIE = @txt WHERE MATRICULE = @matricule;";
                try
                {
                    using (MySqlCommand cmd = new MySqlCommand(rqtSql, conn.Connexion))
                    {
                        cmd.Parameters.AddWithValue("@matricule", matricule);
                        cmd.Parameters.AddWithValue("@txt", txt);

                        conn.Connexion.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        reader.Close();
                        conn.Connexion.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
            }
            else if (var == "MATRICULE_ETRE_RESPONSABLE")
            {
                string rqtSql = "UPDATE EMPLOYE SET MATRICULE_ETRE_RESPONSABLE = @txt WHERE MATRICULE = @matricule;";
                try
                {
                    using (MySqlCommand cmd = new MySqlCommand(rqtSql, conn.Connexion))
                    {
                        cmd.Parameters.AddWithValue("@matricule", matricule);
                        cmd.Parameters.AddWithValue("@txt", txt);

                        conn.Connexion.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        reader.Close();
                        conn.Connexion.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
            }
            
        }





        public bool VerifInsertEmployéBDD(string matricule)
        {
            bool verif = false;
            conn = new Connection();
            string rqtSql = "SELECT * FROM EMPLOYE WHERE MATRICULE = @matricule;";
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(rqtSql, conn.Connexion))
                {
                    cmd.Parameters.AddWithValue("@matricule", matricule);

                    conn.Connexion.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (!reader.HasRows)
                    {
                        verif = true;
                    }
                    reader.Close();
                    conn.Connexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            return verif;
        }


        public void InsertEmployéBDD(string matricule, string nom, string prenom, string dateNaiss, string dateEntree, string dateSortie, string responsable)
        {
            string rqtSql = "";

            conn = new Connection();
            if (responsable == "" && dateSortie == "")
            {
                rqtSql = "INSERT INTO EMPLOYE(MATRICULE, CODEPRODUIT, MATRICULE_ETRE_RESPONSABLE, IDTYPEMETIER, NOM, PRENOM, DATENAISS, DATEENTREE, DATESORTIE, MDPCOMPTE, PREMIERECONNEXION, ADMINI) VALUES (@matricule, 1, null, 1, @nom, @prenom, @dateNaiss, @dateEntree, null, 0000, 0, 0)";
            }
            else if (responsable == "")
            {
                rqtSql = "INSERT INTO EMPLOYE(MATRICULE, CODEPRODUIT, MATRICULE_ETRE_RESPONSABLE, IDTYPEMETIER, NOM, PRENOM, DATENAISS, DATEENTREE, DATESORTIE, MDPCOMPTE, PREMIERECONNEXION, ADMINI) VALUES (@matricule, 1, null, 1, @nom, @prenom, @dateNaiss, @dateEntree, @dateSortie, 0000, 0, 0)";
            }
            else if (dateSortie == "")
            {
                rqtSql = "INSERT INTO EMPLOYE(MATRICULE, CODEPRODUIT, MATRICULE_ETRE_RESPONSABLE, IDTYPEMETIER, NOM, PRENOM, DATENAISS, DATEENTREE, DATESORTIE, MDPCOMPTE, PREMIERECONNEXION, ADMINI) VALUES (@matricule, 1, @responsable, 1, @nom, @prenom, @dateNaiss, @dateEntree, null, 0000, 0, 0)";
            }
            else
            {
                rqtSql = "INSERT INTO EMPLOYE(MATRICULE, CODEPRODUIT, MATRICULE_ETRE_RESPONSABLE, IDTYPEMETIER, NOM, PRENOM, DATENAISS, DATEENTREE, DATESORTIE, MDPCOMPTE, PREMIERECONNEXION, ADMINI) VALUES (@matricule, 1, @responsable, 1, @nom, @prenom, @dateNaiss, @dateEntree, @dateSortie, 0000, 0, 0)";
            }
            
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(rqtSql, conn.Connexion))
                {
                    cmd.Parameters.AddWithValue("@matricule", matricule);
                    cmd.Parameters.AddWithValue("@nom", nom);
                    cmd.Parameters.AddWithValue("@prenom", prenom);
                    cmd.Parameters.AddWithValue("@dateNaiss", dateNaiss);
                    cmd.Parameters.AddWithValue("@dateEntree", dateEntree);
                    cmd.Parameters.AddWithValue("@dateSortie", dateSortie);
                    cmd.Parameters.AddWithValue("@responsable", responsable);

                    conn.Connexion.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    reader.Close();
                    MessageBox.Show("Les ajouts ont été un succès !!", "Erreur", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
        }


        public string GetInfo(string matricule, string var)
        {

            conn = new Connection();
            string rqtSql = "SELECT MATRICULE, MDPCOMPTE, NOM, PRENOM, DATENAISS, MATRICULE_ETRE_RESPONSABLE, DATEENTREE, DATESORTIE FROM EMPLOYE JOIN TYPEMETIER ON EMPLOYE.IDTYPEMETIER = TYPEMETIER.IDTYPEMETIER ";
            rqtSql += " WHERE MATRICULE = @matricule AND NOMMETIER = 'Comptable';";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(rqtSql, conn.Connexion))
                {
                    cmd.Parameters.AddWithValue("@matricule", matricule);
                    conn.Connexion.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        if (var == "nom")
                        {
                            var = reader["NOM"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }

            return var;
        }
        public string GetProduitBDD(string codeProduit, string var)
        {
            conn = new Connection();
            string rqtSql = "SELECT CODEPRODUIT, TYPEPRODUIT FROM TYPEPRODUIT WHERE CODEPRODUIT = @codeProduit;";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(rqtSql, conn.Connexion))
                {
                    cmd.Parameters.AddWithValue("@codeProduit", codeProduit);
                    conn.Connexion.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        if (var == "code produit")
                        {
                            var = reader["CODEPRODUIT"].ToString();
                        }
                        if (var == "type produit")
                        {
                            var = reader["TYPEPRODUIT"].ToString();
                        }
                    }
                    reader.Close();
                    conn.Connexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }

            return var;
        }

        public bool VerifInsertProduitBDD(string codeProduit)
        {
            bool verif = false;
            conn = new Connection();
            string rqtSql = "SELECT * FROM TYPEPRODUIT WHERE CODEPRODUIT = @codeProduit;";
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(rqtSql, conn.Connexion))
                {
                    cmd.Parameters.AddWithValue("@codeProduit", codeProduit);

                    conn.Connexion.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (!reader.HasRows)
                    {
                        verif = true;
                    }
                    reader.Close();
                    conn.Connexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            return verif;
        }


        public void InsertProduitBDD(string codeProduit, string typeProduit)
        {

            conn = new Connection();
            string rqtSql = "INSERT INTO TYPEPRODUIT(CODEPRODUIT, TYPEPRODUIT) VALUES (@codeProduit, @typeProduit)";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(rqtSql, conn.Connexion))
                {
                    cmd.Parameters.AddWithValue("@codeProduit", codeProduit);
                    cmd.Parameters.AddWithValue("@typeProduit", typeProduit);

                    conn.Connexion.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    reader.Close();
                    MessageBox.Show("Les ajouts ont été un succès !!", "Erreur", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
        }





        public void UpdateProduitBDD(string codeProduit, string var, string txt)
        {
            conn = new Connection();

            if (var == "TYPEPRODUIT")
            {
                string rqtSql = "UPDATE TYPEPRODUIT SET TYPEPROODUIT = @txt WHERE CODEPRODUIT = @codeProduit;";
                try
                {
                    using (MySqlCommand cmd = new MySqlCommand(rqtSql, conn.Connexion))
                    {
                        cmd.Parameters.AddWithValue("@codeProduit", codeProduit);
                        cmd.Parameters.AddWithValue("@txt", txt);

                        conn.Connexion.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        reader.Close();
                        conn.Connexion.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
            }

        }

    }
}

