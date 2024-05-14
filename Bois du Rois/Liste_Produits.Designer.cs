namespace Bois_du_Rois
{
    partial class Liste_Produits
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_liste_employes = new System.Windows.Forms.Label();
            this.dgv_Liste_Produits = new System.Windows.Forms.DataGridView();
            this.Menu_Produit = new System.Windows.Forms.Panel();
            this.btn_ajout_produit = new System.Windows.Forms.Button();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.Bouton_Déroulant_Produit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Liste_Produits)).BeginInit();
            this.Menu_Produit.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_liste_employes
            // 
            this.lbl_liste_employes.AutoSize = true;
            this.lbl_liste_employes.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lbl_liste_employes.Location = new System.Drawing.Point(141, 98);
            this.lbl_liste_employes.Name = "lbl_liste_employes";
            this.lbl_liste_employes.Size = new System.Drawing.Size(449, 58);
            this.lbl_liste_employes.TabIndex = 52;
            this.lbl_liste_employes.Text = "Liste des Produits :";
            // 
            // dgv_Liste_Produits
            // 
            this.dgv_Liste_Produits.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_Liste_Produits.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Liste_Produits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Liste_Produits.Location = new System.Drawing.Point(151, 305);
            this.dgv_Liste_Produits.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Liste_Produits.Name = "dgv_Liste_Produits";
            this.dgv_Liste_Produits.RowHeadersWidth = 51;
            this.dgv_Liste_Produits.Size = new System.Drawing.Size(1493, 480);
            this.dgv_Liste_Produits.TabIndex = 49;
            // 
            // Menu_Produit
            // 
            this.Menu_Produit.BackColor = System.Drawing.SystemColors.Control;
            this.Menu_Produit.Controls.Add(this.btn_ajout_produit);
            this.Menu_Produit.Controls.Add(this.btn_modifier);
            this.Menu_Produit.Controls.Add(this.Bouton_Déroulant_Produit);
            this.Menu_Produit.Location = new System.Drawing.Point(151, 237);
            this.Menu_Produit.Margin = new System.Windows.Forms.Padding(4);
            this.Menu_Produit.Name = "Menu_Produit";
            this.Menu_Produit.Size = new System.Drawing.Size(361, 52);
            this.Menu_Produit.TabIndex = 53;
            // 
            // btn_ajout_produit
            // 
            this.btn_ajout_produit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.btn_ajout_produit.FlatAppearance.BorderSize = 0;
            this.btn_ajout_produit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ajout_produit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajout_produit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ajout_produit.Location = new System.Drawing.Point(0, 120);
            this.btn_ajout_produit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ajout_produit.Name = "btn_ajout_produit";
            this.btn_ajout_produit.Size = new System.Drawing.Size(361, 52);
            this.btn_ajout_produit.TabIndex = 44;
            this.btn_ajout_produit.Text = "Ajouter Produit";
            this.btn_ajout_produit.UseVisualStyleBackColor = false;
            this.btn_ajout_produit.Click += new System.EventHandler(this.btn_ajout_produit_Click);
            // 
            // btn_modifier
            // 
            this.btn_modifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.btn_modifier.FlatAppearance.BorderSize = 0;
            this.btn_modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modifier.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_modifier.Location = new System.Drawing.Point(0, 60);
            this.btn_modifier.Margin = new System.Windows.Forms.Padding(4);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(361, 52);
            this.btn_modifier.TabIndex = 42;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.UseVisualStyleBackColor = false;
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
            // 
            // Bouton_Déroulant_Produit
            // 
            this.Bouton_Déroulant_Produit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.Bouton_Déroulant_Produit.FlatAppearance.BorderSize = 0;
            this.Bouton_Déroulant_Produit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bouton_Déroulant_Produit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bouton_Déroulant_Produit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Bouton_Déroulant_Produit.Location = new System.Drawing.Point(0, 0);
            this.Bouton_Déroulant_Produit.Margin = new System.Windows.Forms.Padding(4);
            this.Bouton_Déroulant_Produit.Name = "Bouton_Déroulant_Produit";
            this.Bouton_Déroulant_Produit.Size = new System.Drawing.Size(361, 52);
            this.Bouton_Déroulant_Produit.TabIndex = 41;
            this.Bouton_Déroulant_Produit.Text = "Gestion des Produits";
            this.Bouton_Déroulant_Produit.UseVisualStyleBackColor = false;
            this.Bouton_Déroulant_Produit.Click += new System.EventHandler(this.Bouton_Déroulant_Produit_Click);
            // 
            // Liste_Produits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 850);
            this.Controls.Add(this.Menu_Produit);
            this.Controls.Add(this.lbl_liste_employes);
            this.Controls.Add(this.dgv_Liste_Produits);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Liste_Produits";
            this.Text = "Liste_Produits";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Liste_Produits)).EndInit();
            this.Menu_Produit.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_liste_employes;
        private System.Windows.Forms.DataGridView dgv_Liste_Produits;
        private System.Windows.Forms.Panel Menu_Produit;
        private System.Windows.Forms.Button btn_ajout_produit;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.Button Bouton_Déroulant_Produit;
    }
}