using Bois_du_Rois.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bois_du_Rois
{
    public partial class Ajout_Employé : Form
    {
        private string nom;
        private string prenom;
        private string matricule;
        private string dateNaiss;
        private string responsable;
        private string dateEntree;
        private string dateSortie;
        public Ajout_Employé(string matricule, string nom, string prenom, string dateNaiss, string dateEntree, string dateSortie, string responsable)
        {
            InitializeComponent();
        }
        private void btn_Confirm_Ajout_Click(object sender, EventArgs e)
        {
            string var = "";
            ModificationBDD modificationbdd = new ModificationBDD();
            if (txt_matricule.Text == "" && txt_nom.Text == "" && txt_prenom.Text == "" && txt_dateNaiss.Text == "" && txt_dateEntree.Text == "" && txt_dateSortie.Text == "" && txt_responsable.Text == "")
            {
                MessageBox.Show("Aucun champs n'a été rempli !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txt_matricule.Text == "")
            {
                MessageBox.Show("Le champ (Matricule) est obligatoire !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bool valide = true;
                if (txt_nom.Text == "")
                {
                    MessageBox.Show("Le champ (Nom) est obligatoire !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    valide = false;
                }
                else if (txt_prenom.Text == "")
                {
                    MessageBox.Show("Le champ (Prénom) est obligatoire !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    valide = false;
                }
                else if (txt_dateNaiss.Text == "")
                {
                    MessageBox.Show("Le champ (Date de Naissance) est obligatoire !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    valide = false;
                }
                else if (txt_dateEntree.Text == "")
                {
                    MessageBox.Show("Le champ (Date d'Entrée) est obligatoire !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    valide = false;
                }
                if (valide)
                {
                    matricule = txt_matricule.Text;
                    if (modificationbdd.VerifInsertEmployéBDD(matricule))
                    {
                        nom = txt_nom.Text;
                        prenom = txt_prenom.Text;
                        dateNaiss = txt_dateNaiss.Text;
                        dateEntree = txt_dateEntree.Text;
                        dateSortie = txt_dateSortie.Text;
                        responsable = txt_responsable.Text;

                        modificationbdd.InsertEmployéBDD(matricule, nom, prenom, dateNaiss, dateEntree, dateSortie, responsable);
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Le matricule renseigné existe déjà, mettez-en un autre", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btn_Annulation_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
