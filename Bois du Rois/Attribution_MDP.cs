using System;
using System.Collections.Generic;
using Bois_du_Rois.Model;
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
using Bois_du_Rois.Controllers;

namespace Bois_du_Rois
{
    public partial class Attribution_MDP : Form
    {
        private string matricule;
        public Attribution_MDP(string Matricule)
        {
            InitializeComponent();
            matricule = Matricule;
        }
        private void btn_Confirm_Attribution_Click(object sender, EventArgs e)
        {
            if (txt_matricule.Text == "" && txt_mdp.Text == "" && txt_mdp_confirm.Text == "")
            {
                MessageBox.Show("Aucun champs n'a été rempli !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_matricule.Text == "")
            {
                MessageBox.Show("Aucun matricule n'a été renseigné !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_mdp.Text == "")
            {
                MessageBox.Show("Aucun mot de passe n'est rentré. ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_mdp_confirm.Text == "")
            {
                MessageBox.Show("Aucune confirmation de mot de passe n'est rentré. ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_mdp.Text == txt_mdp_confirm.Text)
            {
                string mdp = BC.HashPassword(txt_mdp.Text);
                ModificationBDD modificationbdd = new ModificationBDD();
                modificationbdd.UpdateMDPBDD(mdp, matricule);
                this.Close();
            }
            else
            {
                MessageBox.Show("Le mot de passe et la confirmation du mot de passe ne sont pas identiques !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btn_Annulation_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
