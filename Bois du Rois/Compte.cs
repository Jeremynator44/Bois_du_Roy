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
    public partial class Compte : Form
    {
        public Compte(string prenom, string nom, string matricule, string dateNaiss, string responsable)
        {
            InitializeComponent();
            txt_prenom.Text = prenom;
            txt_nom.Text = nom;
            txt_matricule.Text = matricule;
            txt_dateNaiss.Text = dateNaiss;
            txt_responsable.Text = responsable;
        }
    }
}
