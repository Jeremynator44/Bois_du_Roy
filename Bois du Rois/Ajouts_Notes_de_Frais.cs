using Bois_du_Rois.Controllers;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bois_du_Rois
{
    public partial class Ajouts_Notes_de_Frais : Form
    {
        private double couttotal;
        private double cout_frais_kilometrique;
        private double cout_repas_midi;
        private double cout_repas_soir;
        private double cout_soir_hors_paris;
        private double cout_soir_paris;

        private int idnote;
        private decimal quantite_frais_kilometrique;
        private decimal quantite_repas_midi;
        private decimal quantite_repas_soir;
        private decimal quantite_soir_hors_paris;
        private decimal quantite_soir_paris;




        public Ajouts_Notes_de_Frais(string matricule)
        {
            InitializeComponent();
            
            txt_matricule.Text = matricule;
        }

        private void btn_Ajout_Fiche_Click(object sender, EventArgs e)
        {
            quantite_frais_kilometrique = numUpDown_Frais_Kilometrique.Value;
            quantite_repas_midi = numUpDown_Repas_Midi.Value;
            quantite_repas_soir = numUpDown_Repas_Soir.Value;
            quantite_soir_hors_paris = numUpDown_Soir_hors_Paris.Value;
            quantite_soir_paris = numUpDown_Soir_Paris.Value;

            if (txt_Date.Text == "")
            {
                MessageBox.Show("Aucune date renseignée !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ModificationBDD modificationbdd = new ModificationBDD();
                cout_frais_kilometrique = modificationbdd.GetCoutBDD("Frais Kilométriques", quantite_frais_kilometrique, couttotal);
                cout_repas_midi = modificationbdd.GetCoutBDD("Repas midi", quantite_repas_midi, couttotal);
                cout_repas_soir = modificationbdd.GetCoutBDD("Repas soir", quantite_repas_soir, couttotal);
                cout_soir_hors_paris = modificationbdd.GetCoutBDD("Soir hors Paris", quantite_soir_hors_paris, couttotal);
                cout_soir_paris = modificationbdd.GetCoutBDD("Soir Paris", quantite_soir_paris, couttotal);
                couttotal = cout_frais_kilometrique + cout_repas_midi + cout_repas_soir + cout_soir_hors_paris + cout_soir_paris;
                idnote = modificationbdd.GetIdBDD(idnote);

                modificationbdd.AjoutNoteDeFraisBDD(txt_matricule.Text, txt_Date.Text, couttotal, idnote, quantite_frais_kilometrique, cout_frais_kilometrique, quantite_repas_midi, cout_repas_midi, quantite_repas_soir, cout_repas_soir, quantite_soir_hors_paris, cout_soir_hors_paris, quantite_soir_paris, cout_soir_paris);
            }
        }

        private void btn_Annulation_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Afficher_Masquer_Click(object sender, EventArgs e)
        {
            if (Calendar_Date.Visible == true)
            {
                Calendar_Date.Visible = false;
                btn_Afficher_Masquer.Text = "Afficher";
            }
            else
            {
                Calendar_Date.Visible = true;
                btn_Afficher_Masquer.Text = "Masquer";
            }
        }

        private void Calendar_Date_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime dateSortie = Calendar_Date.SelectionRange.Start;
            string formattedDate = dateSortie.ToString("yyyy-MM-dd");

            txt_Date.Text = formattedDate;
        }
    }
}
