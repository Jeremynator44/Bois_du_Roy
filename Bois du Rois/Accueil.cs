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

namespace Bois_du_Rois
{
    public partial class Accueil : Form
    {
        SF SousF;
        private DataView dv;
        private Note_De_Frais dt_note;
        private string matricule;



        public Accueil(string Matricule, string PrenomNom)
        {
            InitializeComponent();
            matricule = Matricule;
            lbl_prenom.Text = PrenomNom;
            lbl_matricule.Text = "(" + matricule + ")";


            dt_note = new Note_De_Frais();
            dv = new DataView(dt_note.GetListeNotes(matricule));
            dgv_Notes.DataSource = dv;

            //Gérer la largeur des colonnes
            dgv_Notes.Columns["Notes"].Width = 415;
            dgv_Notes.Columns["Etat"].Width = 300;
            dgv_Notes.Columns["Dates"].Width = 200;
            dgv_Notes.Columns["Coût_Total"].Width = 150;

        }

        private void btn_ajout_fiche_Click(object sender, EventArgs e)
        {
            Ajouts_Notes_de_Frais ajouts_notes_de_frais = new Ajouts_Notes_de_Frais(matricule);
            ajouts_notes_de_frais.Location = new Point(-4, 106);
            ajouts_notes_de_frais.Show();
            this.Hide();
        }
    }
    
}
