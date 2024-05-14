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

namespace Bois_du_Rois.Controllers
{
    public class Identification
    {
        private Connection conn;

        public bool VerifConnexion(string matricule, string mdp)
        {
            conn = new Connection();
            bool verif = false;
            if (matricule == "" || mdp == "") { }
            else 
            {
                string rqtSql = "SELECT MATRICULE, MDPCOMPTE, NOM, PRENOM FROM EMPLOYE JOIN TYPEMETIER ON EMPLOYE.IDTYPEMETIER = TYPEMETIER.IDTYPEMETIER ";
                rqtSql += " WHERE MATRICULE = @matricule AND NOMMETIER = 'Comptable';";
                try
                {
                    using (MySqlCommand cmd = new MySqlCommand(rqtSql, conn.Connexion))
                    {
                        cmd.Parameters.AddWithValue("@matricule", matricule);
                        conn.Connexion.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            string mdpHash = "";
                            while (reader.Read())
                            {
                                mdpHash = reader["MDPCOMPTE"].ToString();
                            }
                            if (BC.Verify(mdp, mdpHash))
                            {
                                verif = true;
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
            }
            return verif;
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
                        if (var == "prenom")
                        {
                            var = reader["PRENOM"].ToString();
                        }
                        if (var == "dateNaiss")
                        {
                            var = reader["DATENAISS"].ToString();
                        }
                        if (var == "responsable")
                        {
                            if (reader["MATRICULE_ETRE_RESPONSABLE"].ToString() != "")
                            {
                                var = "";
                            }
                            else
                            {
                                var = reader["MATRICULE_ETRE_RESPONSABLE"].ToString();
                            }
                        }
                        if (var == "date entree")
                        {
                            var = reader["DATEENTREE"].ToString();
                        }
                        if (var == "date sortie")
                        {
                            var = reader["DATESORTIE"].ToString();
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
        
    }
}

