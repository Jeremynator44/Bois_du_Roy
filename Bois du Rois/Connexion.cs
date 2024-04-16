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
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private void Connexion_Load(object sender, EventArgs e)
        {

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

        }
    }
}
