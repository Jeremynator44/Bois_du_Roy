using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bois_du_Rois.Model;
using Bois_du_Rois.Controllers;
using System.Net;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;
using BC = BCrypt.Net.BCrypt;

namespace Bois_du_Rois
{
    public partial class FormPrincipal : Form
    {
        SF SousF;
        private string nom;
        private string prenom;
        private string PrenomNom;
        private string matricule;
        private string dateNaiss;
        private string responsable;
        public FormPrincipal(string Matricule, string Nom, string Prenom, string DateNaiss, string Responsable)
        {
            InitializeComponent();
            PrenomNom = Nom + " " + Prenom;
            nom = Nom; 
            prenom = Prenom;
            matricule = Matricule;
            dateNaiss = DateNaiss;
            responsable = Responsable;
            Bouton_Déroulant_Menu.Text = PrenomNom;



            SousF = new SF(panelSF);
            SousF.openChildForm(new Accueil(matricule, PrenomNom));
        }

        private void Bouton_Déroulant_Menu_Click(object sender, EventArgs e)
        {
            if (Menu.Height == 262)
            {
                Menu.Height = 89;
            }
            else
            {
                Menu.Height = 262;
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            Menu.Height = 89;
        }

        
        private void btn_accueil_Click(object sender, EventArgs e)
        {
            SousF.openChildForm(new Accueil(matricule, PrenomNom));
        }

        private void btn_ndf_employés_Click(object sender, EventArgs e)
        {
            SousF.openChildForm(new NDF_Employé(matricule));
        }
        private void btn_liste_employés_Click(object sender, EventArgs e)
        {
            SousF.openChildForm(new Liste_Employés());
        }

        private void btn_liste_produits_Click(object sender, EventArgs e)
        {
            SousF.openChildForm(new Liste_Produits());
        }


        private void btn_compte_Click(object sender, EventArgs e)
        {
            SousF.openChildForm(new Compte(prenom,nom,matricule,dateNaiss,responsable));
        }
        private void btn_deconnexion_Click(object sender, EventArgs e)
        {
            DialogResult valider = MessageBox.Show("Voulez vous vraiment vous déconnecter ?", "Se Déconnecter", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (valider == DialogResult.Yes)
            {
                Connexion connexion = new Connexion();
                connexion.Show();
                this.Hide();
            }
                
        }
    }
}
