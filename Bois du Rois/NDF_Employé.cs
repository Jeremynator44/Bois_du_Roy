using Bois_du_Rois.Controllers;
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
    public partial class NDF_Employé : Form
    {

        private DataView dv;
        private Note_De_Frais dt_note;

        public NDF_Employé(string matricule)
        {
            InitializeComponent();
            dt_note = new Note_De_Frais();
            matricule = "";
            dv = new DataView(dt_note.GetListeNotes(matricule));
            dgv_Notes.DataSource = dv;

            //Gérer la largeur des colonnes
            dgv_Notes.Columns["Notes"].Width = 400;
            dgv_Notes.Columns["Etat"].Width = 300;
            dgv_Notes.Columns["Dates"].Width = 200;
            dgv_Notes.Columns["Coût_Total"].Width = 150;

        }

    }
}
