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
    public partial class Connexion : Form
    {
        private string nom;
        private string prenom;
        private string dateNaiss;
        private string responsable;
        private string dateEntree;
        private string dateSortie;



        public Connexion()
        {
            InitializeComponent();
            nom = "nom";
            prenom = "prenom";
            dateNaiss = "dateNaiss";
            responsable = "responsable";
            dateEntree = "date entree";
            dateSortie = "date sortie";
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "" && txtMdp.Text == "")
            {
                MessageBox.Show("Aucun identifiant et mot de passe ne sont rentrés !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtLogin.Text == "")
            {
                MessageBox.Show("Aucun identifiant n'est rentré !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtMdp.Text == "")
            {
                MessageBox.Show("Aucun mot de passe n'est rentré !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Identification identification = new Identification();

            if (identification.VerifConnexion(txtLogin.Text, txtMdp.Text))
            {
                nom = identification.GetInfo(txtLogin.Text,  nom);
                prenom = identification.GetInfo(txtLogin.Text, prenom);
                dateNaiss = identification.GetInfo(txtLogin.Text, dateNaiss);
                responsable = identification.GetInfo(txtLogin.Text, responsable);
                dateEntree = identification.GetInfo(txtLogin.Text, dateEntree);
                dateSortie = identification.GetInfo(txtLogin.Text, dateSortie);


                FormPrincipal formprincipal = new FormPrincipal(txtLogin.Text, nom, prenom, dateNaiss, responsable, dateEntree, dateSortie);
                formprincipal.Show();
                this.Hide();

            } else
            {
                MessageBox.Show("Votre mot de passe ou identifiant est incorrect !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void btn_Afficher_Masquer_Click(object sender, EventArgs e)
        {
           if (txtMdp.UseSystemPasswordChar == true)
           {
                txtMdp.UseSystemPasswordChar = false;
                btn_Afficher_Masquer.Text = "Masquer";
           }
           else
           {
                txtMdp.UseSystemPasswordChar =  true;
                btn_Afficher_Masquer.Text = "Afficher";
           }
        }
    }
}
