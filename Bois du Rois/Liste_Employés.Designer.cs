namespace Bois_du_Rois
{
    partial class Liste_Employés
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
            this.dgv_Liste_Employés = new System.Windows.Forms.DataGridView();
            this.Bouton_Déroulant_Employé = new System.Windows.Forms.Button();
            this.lbl_liste_employes = new System.Windows.Forms.Label();
            this.Menu_Employé = new System.Windows.Forms.Panel();
            this.btn_ajout_employé = new System.Windows.Forms.Button();
            this.btn_attribution_mdp = new System.Windows.Forms.Button();
            this.btn_modifier = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Liste_Employés)).BeginInit();
            this.Menu_Employé.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Liste_Employés
            // 
            this.dgv_Liste_Employés.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_Liste_Employés.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Liste_Employés.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Liste_Employés.Location = new System.Drawing.Point(152, 304);
            this.dgv_Liste_Employés.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Liste_Employés.Name = "dgv_Liste_Employés";
            this.dgv_Liste_Employés.RowHeadersWidth = 51;
            this.dgv_Liste_Employés.Size = new System.Drawing.Size(1493, 480);
            this.dgv_Liste_Employés.TabIndex = 43;
            // 
            // Bouton_Déroulant_Employé
            // 
            this.Bouton_Déroulant_Employé.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.Bouton_Déroulant_Employé.FlatAppearance.BorderSize = 0;
            this.Bouton_Déroulant_Employé.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bouton_Déroulant_Employé.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bouton_Déroulant_Employé.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Bouton_Déroulant_Employé.Location = new System.Drawing.Point(0, 0);
            this.Bouton_Déroulant_Employé.Margin = new System.Windows.Forms.Padding(4);
            this.Bouton_Déroulant_Employé.Name = "Bouton_Déroulant_Employé";
            this.Bouton_Déroulant_Employé.Size = new System.Drawing.Size(357, 52);
            this.Bouton_Déroulant_Employé.TabIndex = 41;
            this.Bouton_Déroulant_Employé.Text = "Gestion des Employés";
            this.Bouton_Déroulant_Employé.UseVisualStyleBackColor = false;
            this.Bouton_Déroulant_Employé.Click += new System.EventHandler(this.Bouton_Déroulant_Employé_Click);
            // 
            // lbl_liste_employes
            // 
            this.lbl_liste_employes.AutoSize = true;
            this.lbl_liste_employes.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lbl_liste_employes.Location = new System.Drawing.Point(142, 97);
            this.lbl_liste_employes.Name = "lbl_liste_employes";
            this.lbl_liste_employes.Size = new System.Drawing.Size(485, 58);
            this.lbl_liste_employes.TabIndex = 46;
            this.lbl_liste_employes.Text = "Liste des Employés :";
            // 
            // Menu_Employé
            // 
            this.Menu_Employé.BackColor = System.Drawing.SystemColors.Control;
            this.Menu_Employé.Controls.Add(this.btn_ajout_employé);
            this.Menu_Employé.Controls.Add(this.btn_attribution_mdp);
            this.Menu_Employé.Controls.Add(this.btn_modifier);
            this.Menu_Employé.Controls.Add(this.Bouton_Déroulant_Employé);
            this.Menu_Employé.Location = new System.Drawing.Point(152, 236);
            this.Menu_Employé.Margin = new System.Windows.Forms.Padding(4);
            this.Menu_Employé.Name = "Menu_Employé";
            this.Menu_Employé.Size = new System.Drawing.Size(361, 52);
            this.Menu_Employé.TabIndex = 47;
            // 
            // btn_ajout_employé
            // 
            this.btn_ajout_employé.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.btn_ajout_employé.FlatAppearance.BorderSize = 0;
            this.btn_ajout_employé.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ajout_employé.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajout_employé.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ajout_employé.Location = new System.Drawing.Point(0, 180);
            this.btn_ajout_employé.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ajout_employé.Name = "btn_ajout_employé";
            this.btn_ajout_employé.Size = new System.Drawing.Size(361, 52);
            this.btn_ajout_employé.TabIndex = 44;
            this.btn_ajout_employé.Text = "Ajouter Employé";
            this.btn_ajout_employé.UseVisualStyleBackColor = false;
            this.btn_ajout_employé.Click += new System.EventHandler(this.btn_ajout_employé_Click);
            // 
            // btn_attribution_mdp
            // 
            this.btn_attribution_mdp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.btn_attribution_mdp.FlatAppearance.BorderSize = 0;
            this.btn_attribution_mdp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_attribution_mdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_attribution_mdp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_attribution_mdp.Location = new System.Drawing.Point(0, 60);
            this.btn_attribution_mdp.Margin = new System.Windows.Forms.Padding(4);
            this.btn_attribution_mdp.Name = "btn_attribution_mdp";
            this.btn_attribution_mdp.Size = new System.Drawing.Size(361, 52);
            this.btn_attribution_mdp.TabIndex = 43;
            this.btn_attribution_mdp.Text = "Attribuer un Mot de Passe";
            this.btn_attribution_mdp.UseVisualStyleBackColor = false;
            this.btn_attribution_mdp.Click += new System.EventHandler(this.btn_attribution_mdp_Click);
            // 
            // btn_modifier
            // 
            this.btn_modifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.btn_modifier.FlatAppearance.BorderSize = 0;
            this.btn_modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modifier.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_modifier.Location = new System.Drawing.Point(0, 120);
            this.btn_modifier.Margin = new System.Windows.Forms.Padding(4);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(361, 52);
            this.btn_modifier.TabIndex = 42;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.UseVisualStyleBackColor = false;
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
            // 
            // Liste_Employés
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 850);
            this.Controls.Add(this.Menu_Employé);
            this.Controls.Add(this.lbl_liste_employes);
            this.Controls.Add(this.dgv_Liste_Employés);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Liste_Employés";
            this.Text = "Liste_Employés";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Liste_Employés)).EndInit();
            this.Menu_Employé.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_Liste_Employés;
        private System.Windows.Forms.Button Bouton_Déroulant_Employé;
        private System.Windows.Forms.Label lbl_liste_employes;
        private System.Windows.Forms.Panel Menu_Employé;
        private System.Windows.Forms.Button btn_ajout_employé;
        private System.Windows.Forms.Button btn_attribution_mdp;
        private System.Windows.Forms.Button btn_modifier;
    }
}