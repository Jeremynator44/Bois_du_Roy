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
    public partial class Liste_Employés : Form
    {
        private DataView dv;
        private ListeEmployés dt_liste_employé;

        public Liste_Employés()
        {
            InitializeComponent();
            dt_liste_employé = new ListeEmployés();
            dv = new DataView(dt_liste_employé.GetListeEmployés());
            dgv_Liste_Employés.DataSource = dv;

            //Gérer la largeur des colonnes
            dgv_Liste_Employés.Columns["Matricule"].Width = 100;
            dgv_Liste_Employés.Columns["Nom"].Width = 100;
            dgv_Liste_Employés.Columns["Prénom"].Width = 100;
            dgv_Liste_Employés.Columns["Type Produit"].Width = 250;
            dgv_Liste_Employés.Columns["Date de Naissance"].Width = 150;
            dgv_Liste_Employés.Columns["Date Entrée"].Width = 125;
            dgv_Liste_Employés.Columns["Date Sortie"].Width = 125;
            dgv_Liste_Employés.Columns["Responsable"].Width = 100;

        }
    }
}
