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
        private DataView dv;
        private Note_De_Frais dt_note;

        public Accueil()
        {
            InitializeComponent();

            dt_note = new Note_De_Frais();
            dv = new DataView(dt_note.GetListeNotes());
            dgv_Notes.DataSource = dv;

            //Gérer la largeur des colonnes
            dgv_Notes.Columns["Notes"].Width = 400;
            dgv_Notes.Columns["Etat"].Width = 300;
            dgv_Notes.Columns["Dates"].Width = 200;
            dgv_Notes.Columns["Coût_Total"].Width = 200;

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

        private void Accueil_Load(object sender, EventArgs e)
        {
            Menu.Height = 89;
        }

    }
}
