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
        private string nom;
        private string prenom;
        private string matricule;
        private string dateNaiss;
        private string responsable;
        private string dateEntree;
        private string dateSortie;

        public Liste_Employés(string Matricule, string Nom, string Prenom, string DateNaiss, string Responsable, string DateEntree, string DateSortie)
        {
            InitializeComponent();
            nom = Nom;
            prenom = Prenom;
            matricule = Matricule;
            dateNaiss = DateNaiss;
            responsable = Responsable;
            dateEntree = DateEntree;
            dateSortie = DateSortie;
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


        private void Bouton_Déroulant_Employé_Click(object sender, EventArgs e)
        {
            if (Menu_Employé.Height == 190)
            {
                Menu_Employé.Height = 45;
            }
            else
            {
                Menu_Employé.Height = 190;
            }
        }

        private void Liste_Employés_Load(object sender, EventArgs e)
        {
            Menu_Employé.Height = 52;
        }

        private void btn_attribution_mdp_Click(object sender, EventArgs e)
        {
            Attribution_MDP attribution_mdp = new Attribution_MDP(matricule);
            attribution_mdp.Location = new Point(-4,106);
            attribution_mdp.Show();
            this.Hide();
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            Modif_Employé modif_employé = new Modif_Employé(matricule, nom, prenom, dateNaiss, responsable, dateEntree, dateSortie);
            modif_employé.Location = new Point(-4, 106);
            modif_employé.Show();
            this.Hide();
        }

        private void btn_ajout_employé_Click(object sender, EventArgs e)
        {
            Ajout_Employé ajout_employé = new Ajout_Employé(matricule, nom, prenom, dateNaiss, responsable, dateEntree, dateSortie);
            ajout_employé.Location = new Point(-4, 106);
            ajout_employé.Show();
            this.Hide();
        }
    }
}
