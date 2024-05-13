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
            this.btn_exporter = new System.Windows.Forms.Button();
            this.dgv_Liste_Employés = new System.Windows.Forms.DataGridView();
            this.btn_copier = new System.Windows.Forms.Button();
            this.btn_ajout_fiche = new System.Windows.Forms.Button();
            this.lbl_liste_employes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Liste_Employés)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exporter
            // 
            this.btn_exporter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.btn_exporter.FlatAppearance.BorderSize = 0;
            this.btn_exporter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exporter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exporter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_exporter.Location = new System.Drawing.Point(1446, 236);
            this.btn_exporter.Margin = new System.Windows.Forms.Padding(4);
            this.btn_exporter.Name = "btn_exporter";
            this.btn_exporter.Size = new System.Drawing.Size(199, 52);
            this.btn_exporter.TabIndex = 44;
            this.btn_exporter.Text = "Exporter";
            this.btn_exporter.UseVisualStyleBackColor = false;
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
            // btn_copier
            // 
            this.btn_copier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.btn_copier.FlatAppearance.BorderSize = 0;
            this.btn_copier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_copier.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_copier.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_copier.Location = new System.Drawing.Point(569, 236);
            this.btn_copier.Margin = new System.Windows.Forms.Padding(4);
            this.btn_copier.Name = "btn_copier";
            this.btn_copier.Size = new System.Drawing.Size(199, 52);
            this.btn_copier.TabIndex = 42;
            this.btn_copier.Text = "Copier";
            this.btn_copier.UseVisualStyleBackColor = false;
            // 
            // btn_ajout_fiche
            // 
            this.btn_ajout_fiche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.btn_ajout_fiche.FlatAppearance.BorderSize = 0;
            this.btn_ajout_fiche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ajout_fiche.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajout_fiche.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ajout_fiche.Location = new System.Drawing.Point(152, 236);
            this.btn_ajout_fiche.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ajout_fiche.Name = "btn_ajout_fiche";
            this.btn_ajout_fiche.Size = new System.Drawing.Size(361, 52);
            this.btn_ajout_fiche.TabIndex = 41;
            this.btn_ajout_fiche.Text = "+ Ajouter une nouvelle fiche";
            this.btn_ajout_fiche.UseVisualStyleBackColor = false;
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
            // Liste_Employés
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 850);
            this.Controls.Add(this.lbl_liste_employes);
            this.Controls.Add(this.btn_exporter);
            this.Controls.Add(this.dgv_Liste_Employés);
            this.Controls.Add(this.btn_copier);
            this.Controls.Add(this.btn_ajout_fiche);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Liste_Employés";
            this.Text = "Liste_Employés";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Liste_Employés)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_exporter;
        private System.Windows.Forms.DataGridView dgv_Liste_Employés;
        private System.Windows.Forms.Button btn_copier;
        private System.Windows.Forms.Button btn_ajout_fiche;
        private System.Windows.Forms.Label lbl_liste_employes;
    }
}