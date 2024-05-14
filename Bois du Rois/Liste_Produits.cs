using Bois_du_Rois.Controllers;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bois_du_Rois
{
    public partial class Liste_Produits : Form
    {
        private DataView dv;
        private ListeProduits dt_liste_produit;
        private string codeProduit;
        private string typeProduit;

        public Liste_Produits()
        {
            InitializeComponent();
            codeProduit = "code produit";
            typeProduit = "type produit";
            
            ModificationBDD modificationbdd = new ModificationBDD();
            codeProduit = modificationbdd.GetProduitBDD(codeProduit, codeProduit);
            typeProduit = modificationbdd.GetProduitBDD(codeProduit, typeProduit);

            dt_liste_produit = new ListeProduits();
            dv = new DataView(dt_liste_produit.GetListeProduits());
            dgv_Liste_Produits.DataSource = dv;

            //Gérer la largeur des colonnes
            dgv_Liste_Produits.Columns["Code Produit"].Width = 500;
            dgv_Liste_Produits.Columns["Type Produit"].Width = 565;

        }

        private void Bouton_Déroulant_Produit_Click(object sender, EventArgs e)
        {
            if (Menu_Produit.Height == 140)
            {
                Menu_Produit.Height = 45;
            }
            else
            {
                Menu_Produit.Height = 140;
            }
        }

        private void Liste_Produit_Load(object sender, EventArgs e)
        {
            Menu_Produit.Height = 52;
        }



        private void btn_ajout_produit_Click(object sender, EventArgs e)
        {
            Ajout_Produit ajout_produit = new Ajout_Produit(codeProduit, typeProduit);
            ajout_produit.Location = new Point(-4, 106);
            ajout_produit.Show();
            this.Hide();
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            Modif_Produit modif_produit = new Modif_Produit(codeProduit, typeProduit);
            modif_produit.Location = new Point(-4, 106);
            modif_produit.Show();
            this.Hide();
        }
    }
}