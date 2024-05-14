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
    public partial class Modif_Employé : Form
    {
        private string nom;
        private string prenom;
        private string matricule;
        private string dateNaiss;
        private string responsable;
        private string dateEntree;
        private string dateSortie;
        public Modif_Employé(string Matricule, string Nom, string Prenom, string DateNaiss, string Responsable, string DateEntree, string DateSortie)
        {
            InitializeComponent();
            nom = Nom;
            prenom = Prenom;
            matricule = Matricule;
            dateNaiss = DateNaiss;
            responsable = Responsable;
            dateEntree = DateEntree;
            dateSortie = DateSortie;

            txt_matricule.Text = matricule;
            txt_nom.Text = nom;
            txt_prenom.Text = prenom;
            txt_dateNaiss.Text = dateNaiss;
            txt_dateEntree.Text = dateEntree;
            txt_dateSortie.Text = dateSortie;
            txt_responsable.Text = responsable;
        }
        private void btn_Confirm_Modif_Click(object sender, EventArgs e)
        {
            string var = "";
            if (txt_matricule.Text == matricule && txt_nom.Text == nom && txt_prenom.Text == prenom && txt_dateNaiss.Text == dateNaiss && txt_dateEntree.Text == dateEntree && txt_dateSortie.Text == dateSortie && txt_responsable.Text == responsable)
            {
                MessageBox.Show("Aucun champs n'a été modifié !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                matricule = txt_matricule.Text;
                ModificationBDD modificationbdd = new ModificationBDD();
                if (txt_nom.Text != nom)
                {
                    nom = txt_nom.Text;
                    var = "NOM";
                    modificationbdd.UpdateEmployéBDD(matricule, var, nom);
                }
                if (txt_prenom.Text != prenom)
                {
                    prenom = txt_prenom.Text;
                    var = "PRENOM";
                    modificationbdd.UpdateEmployéBDD(matricule, var, prenom);
                }
                if (txt_dateNaiss.Text != dateNaiss)
                {
                    dateNaiss = txt_dateNaiss.Text;
                    var = "DATENAISS";
                    modificationbdd.UpdateEmployéBDD(matricule, var, dateNaiss);
                }
                if (txt_dateEntree.Text != dateEntree)
                {
                    dateEntree = txt_dateEntree.Text;
                    var = "DATEENTREE";
                    modificationbdd.UpdateEmployéBDD(matricule, var, dateEntree);
                }
                if (txt_dateSortie.Text != dateSortie)
                {
                    dateSortie = txt_dateSortie.Text;
                    var = "DATESORTIE";
                    modificationbdd.UpdateEmployéBDD(matricule, var, dateSortie);
                }
                if (txt_responsable.Text != responsable)
                {
                    responsable = txt_responsable.Text;
                    var = "MATRICULE_ETRE_RESPONSABLE";
                    MessageBox.Show("var = "+var+" matricule = "+matricule+" txt = "+responsable, "Erreur", MessageBoxButtons.OK);
                    modificationbdd.UpdateEmployéBDD(matricule, var, responsable);
                }
                MessageBox.Show("Les modifications ont été mise à jour avec succès !!", "Erreur", MessageBoxButtons.OK);
                this.Close();
            }


        }

        private void btn_Annulation_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
