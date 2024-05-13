using Bois_du_Rois.Controllers;
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

        public Liste_Produits()
        {
            InitializeComponent();
            dt_liste_produit = new ListeProduits();
            dv = new DataView(dt_liste_produit.GetListeProduits());
            dgv_Liste_Produits.DataSource = dv;

            //Gérer la largeur des colonnes
            dgv_Liste_Produits.Columns["Code Produit"].Width = 500;
            dgv_Liste_Produits.Columns["Type Produit"].Width = 565;

        }
    }
}