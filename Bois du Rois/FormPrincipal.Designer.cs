namespace Bois_du_Rois
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.Menu = new System.Windows.Forms.Panel();
            this.Bouton_Déroulant_Menu = new System.Windows.Forms.Button();
            this.btn_deconnexion = new System.Windows.Forms.Button();
            this.btn_compte = new System.Windows.Forms.Button();
            this.btn_liste_produits = new System.Windows.Forms.Button();
            this.btn_liste_employés = new System.Windows.Forms.Button();
            this.btn_ndf_employés = new System.Windows.Forms.Button();
            this.btn_accueil = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelSF = new System.Windows.Forms.Panel();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.DimGray;
            this.Menu.Controls.Add(this.Bouton_Déroulant_Menu);
            this.Menu.Controls.Add(this.btn_deconnexion);
            this.Menu.Controls.Add(this.btn_compte);
            this.Menu.Location = new System.Drawing.Point(1761, -1);
            this.Menu.Margin = new System.Windows.Forms.Padding(4);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(288, 110);
            this.Menu.TabIndex = 40;
            // 
            // Bouton_Déroulant_Menu
            // 
            this.Bouton_Déroulant_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Bouton_Déroulant_Menu.FlatAppearance.BorderSize = 0;
            this.Bouton_Déroulant_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bouton_Déroulant_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.Bouton_Déroulant_Menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Bouton_Déroulant_Menu.Location = new System.Drawing.Point(0, 0);
            this.Bouton_Déroulant_Menu.Margin = new System.Windows.Forms.Padding(4);
            this.Bouton_Déroulant_Menu.Name = "Bouton_Déroulant_Menu";
            this.Bouton_Déroulant_Menu.Size = new System.Drawing.Size(296, 110);
            this.Bouton_Déroulant_Menu.TabIndex = 0;
            this.Bouton_Déroulant_Menu.Text = "Jean-Durand";
            this.Bouton_Déroulant_Menu.UseVisualStyleBackColor = false;
            this.Bouton_Déroulant_Menu.Click += new System.EventHandler(this.Bouton_Déroulant_Menu_Click);
            // 
            // btn_deconnexion
            // 
            this.btn_deconnexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_deconnexion.FlatAppearance.BorderSize = 0;
            this.btn_deconnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deconnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btn_deconnexion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_deconnexion.Location = new System.Drawing.Point(0, 222);
            this.btn_deconnexion.Margin = new System.Windows.Forms.Padding(4);
            this.btn_deconnexion.Name = "btn_deconnexion";
            this.btn_deconnexion.Size = new System.Drawing.Size(288, 99);
            this.btn_deconnexion.TabIndex = 2;
            this.btn_deconnexion.Text = "Déconnexion";
            this.btn_deconnexion.UseVisualStyleBackColor = false;
            this.btn_deconnexion.Click += new System.EventHandler(this.btn_deconnexion_Click);
            // 
            // btn_compte
            // 
            this.btn_compte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_compte.FlatAppearance.BorderSize = 0;
            this.btn_compte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_compte.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.btn_compte.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_compte.Location = new System.Drawing.Point(0, 113);
            this.btn_compte.Margin = new System.Windows.Forms.Padding(4);
            this.btn_compte.Name = "btn_compte";
            this.btn_compte.Size = new System.Drawing.Size(288, 105);
            this.btn_compte.TabIndex = 1;
            this.btn_compte.Text = "Compte";
            this.btn_compte.UseVisualStyleBackColor = false;
            this.btn_compte.Click += new System.EventHandler(this.btn_compte_Click);
            // 
            // btn_liste_produits
            // 
            this.btn_liste_produits.BackColor = System.Drawing.Color.DimGray;
            this.btn_liste_produits.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_liste_produits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_liste_produits.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_liste_produits.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_liste_produits.Location = new System.Drawing.Point(1498, -1);
            this.btn_liste_produits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_liste_produits.Name = "btn_liste_produits";
            this.btn_liste_produits.Size = new System.Drawing.Size(199, 110);
            this.btn_liste_produits.TabIndex = 36;
            this.btn_liste_produits.Text = "Liste Produits";
            this.btn_liste_produits.UseVisualStyleBackColor = false;
            this.btn_liste_produits.Click += new System.EventHandler(this.btn_liste_produits_Click);
            // 
            // btn_liste_employés
            // 
            this.btn_liste_employés.BackColor = System.Drawing.Color.DimGray;
            this.btn_liste_employés.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_liste_employés.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_liste_employés.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_liste_employés.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_liste_employés.Location = new System.Drawing.Point(1209, -1);
            this.btn_liste_employés.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_liste_employés.Name = "btn_liste_employés";
            this.btn_liste_employés.Size = new System.Drawing.Size(217, 110);
            this.btn_liste_employés.TabIndex = 35;
            this.btn_liste_employés.Text = "Liste Employés";
            this.btn_liste_employés.UseVisualStyleBackColor = false;
            this.btn_liste_employés.Click += new System.EventHandler(this.btn_liste_employés_Click);
            // 
            // btn_ndf_employés
            // 
            this.btn_ndf_employés.BackColor = System.Drawing.Color.DimGray;
            this.btn_ndf_employés.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_ndf_employés.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ndf_employés.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ndf_employés.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ndf_employés.Location = new System.Drawing.Point(922, -1);
            this.btn_ndf_employés.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ndf_employés.Name = "btn_ndf_employés";
            this.btn_ndf_employés.Size = new System.Drawing.Size(229, 110);
            this.btn_ndf_employés.TabIndex = 34;
            this.btn_ndf_employés.Text = "NDF Employés";
            this.btn_ndf_employés.UseVisualStyleBackColor = false;
            this.btn_ndf_employés.Click += new System.EventHandler(this.btn_ndf_employés_Click);
            // 
            // btn_accueil
            // 
            this.btn_accueil.BackColor = System.Drawing.Color.DimGray;
            this.btn_accueil.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_accueil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_accueil.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_accueil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_accueil.Location = new System.Drawing.Point(31, -1);
            this.btn_accueil.Margin = new System.Windows.Forms.Padding(4);
            this.btn_accueil.Name = "btn_accueil";
            this.btn_accueil.Size = new System.Drawing.Size(341, 110);
            this.btn_accueil.TabIndex = 39;
            this.btn_accueil.Text = "Bois du Roy";
            this.btn_accueil.UseVisualStyleBackColor = false;
            this.btn_accueil.Click += new System.EventHandler(this.btn_accueil_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(344, -1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(164, 110);
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(0, -1);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1970, 110);
            this.label2.TabIndex = 37;
            // 
            // panelSF
            // 
            this.panelSF.Location = new System.Drawing.Point(-4, 106);
            this.panelSF.Name = "panelSF";
            this.panelSF.Size = new System.Drawing.Size(1942, 850);
            this.panelSF.TabIndex = 41;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 752);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.btn_liste_produits);
            this.Controls.Add(this.btn_liste_employés);
            this.Controls.Add(this.btn_ndf_employés);
            this.Controls.Add(this.btn_accueil);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelSF);
            this.Name = "FormPrincipal";
            this.Text = "Bois du Roy";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.Button btn_deconnexion;
        private System.Windows.Forms.Button btn_compte;
        private System.Windows.Forms.Button Bouton_Déroulant_Menu;
        private System.Windows.Forms.Button btn_liste_produits;
        private System.Windows.Forms.Button btn_liste_employés;
        private System.Windows.Forms.Button btn_ndf_employés;
        private System.Windows.Forms.Button btn_accueil;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelSF;
    }
}