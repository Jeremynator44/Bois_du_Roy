using Bois_du_Rois.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bois_du_Rois
{
    public partial class Modif_Produit : Form
    {
        private string codeProduit;
        private string typeProduit;

        public Modif_Produit(string CodeProduit, string TypeProduit)
        {
            InitializeComponent();
            codeProduit = CodeProduit;
            typeProduit = TypeProduit;

            txt_code_produit.Text = codeProduit;
            txt_type_produit.Text = typeProduit;
        }
        private void btn_Confirm_Modif_Click(object sender, EventArgs e)
        {
            string var = "";
            if (txt_code_produit.Text == codeProduit && txt_type_produit.Text == typeProduit)
            {
                MessageBox.Show("Aucun champs n'a été modifié !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                codeProduit = txt_code_produit.Text;
                ModificationBDD modificationbdd = new ModificationBDD();
                if (txt_type_produit.Text != typeProduit)
                {
                    typeProduit = txt_type_produit.Text;
                    var = "TYPEPRODUIT";
                    modificationbdd.UpdateProduitBDD(codeProduit, var, typeProduit);
                }
                MessageBox.Show("Les modifications ont été mise à jour avec succès !!", "Erreur", MessageBoxButtons.OK);
                this.Close();
            }


        }

        private void btn_Annulation_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
