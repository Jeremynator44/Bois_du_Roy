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
    public partial class Ajout_Produit : Form
    {
        private string codeProduit;
        private string typeProduit;

        public Ajout_Produit(string codeProduit, string typeProduit)
        {
            InitializeComponent();
        }
        private void btn_Confirm_Ajout_Click(object sender, EventArgs e)
        {
            string var = "";
            ModificationBDD modificationbdd = new ModificationBDD();
            if (txt_code_produit.Text == "" && txt_type_produit.Text == "")
            {
                MessageBox.Show("Aucun champs n'a été rempli !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txt_code_produit.Text == "")
            {
                MessageBox.Show("Le champ (code produit) est obligatoire !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bool valide = true;
                if (txt_type_produit.Text == "")
                {
                    MessageBox.Show("Le champ (type de produit) est obligatoire !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    valide = false;
                }
                if (valide)
                {
                    codeProduit = txt_code_produit.Text;
                    if (modificationbdd.VerifInsertProduitBDD(codeProduit))
                    {
                        typeProduit = txt_type_produit.Text;
                        
                        modificationbdd.InsertProduitBDD(codeProduit, typeProduit);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Le code produit renseigné existe déjà, mettez-en un autre", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btn_Annulation_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
