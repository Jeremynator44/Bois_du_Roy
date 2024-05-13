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


        public Connexion()
        {
            InitializeComponent();
            nom = "nom";
            prenom = "prenom";
            dateNaiss = "dateNaiss";
            responsable = "responsable";
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

                FormPrincipal formprincipal = new FormPrincipal(txtLogin.Text, nom, prenom, dateNaiss, responsable);
                formprincipal.Show();
                this.Hide();

            } else
            {
                MessageBox.Show("Votre mot de passe ou identifiant est incorrect !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
           if (txtMdp.UseSystemPasswordChar == true)
           {
                txtMdp.UseSystemPasswordChar = false;
                button1.Text = "Masquer";
           }
           else
           {
                txtMdp.UseSystemPasswordChar =  true;
                button1.Text = "Afficher";
           }
        }
    }
}
