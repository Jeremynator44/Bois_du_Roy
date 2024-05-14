namespace Bois_du_Rois
{
    partial class Accueil
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
            this.lbl_prenom = new System.Windows.Forms.Label();
            this.btn_ajout_fiche = new System.Windows.Forms.Button();
            this.dgv_Notes = new System.Windows.Forms.DataGridView();
            this.lbl_matricule = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Notes)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_prenom
            // 
            this.lbl_prenom.AutoSize = true;
            this.lbl_prenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prenom.Location = new System.Drawing.Point(146, 103);
            this.lbl_prenom.Name = "lbl_prenom";
            this.lbl_prenom.Size = new System.Drawing.Size(67, 58);
            this.lbl_prenom.TabIndex = 23;
            this.lbl_prenom.Text = "...";
            // 
            // btn_ajout_fiche
            // 
            this.btn_ajout_fiche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.btn_ajout_fiche.FlatAppearance.BorderSize = 0;
            this.btn_ajout_fiche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ajout_fiche.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajout_fiche.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ajout_fiche.Location = new System.Drawing.Point(156, 236);
            this.btn_ajout_fiche.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ajout_fiche.Name = "btn_ajout_fiche";
            this.btn_ajout_fiche.Size = new System.Drawing.Size(361, 52);
            this.btn_ajout_fiche.TabIndex = 29;
            this.btn_ajout_fiche.Text = "+ Ajouter une nouvelle fiche";
            this.btn_ajout_fiche.UseVisualStyleBackColor = false;
            this.btn_ajout_fiche.Click += new System.EventHandler(this.btn_ajout_fiche_Click);
            // 
            // dgv_Notes
            // 
            this.dgv_Notes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_Notes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Notes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Notes.Location = new System.Drawing.Point(156, 304);
            this.dgv_Notes.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Notes.Name = "dgv_Notes";
            this.dgv_Notes.RowHeadersWidth = 51;
            this.dgv_Notes.Size = new System.Drawing.Size(1493, 480);
            this.dgv_Notes.TabIndex = 31;
            // 
            // lbl_matricule
            // 
            this.lbl_matricule.AutoSize = true;
            this.lbl_matricule.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_matricule.Location = new System.Drawing.Point(583, 103);
            this.lbl_matricule.Name = "lbl_matricule";
            this.lbl_matricule.Size = new System.Drawing.Size(114, 58);
            this.lbl_matricule.TabIndex = 35;
            this.lbl_matricule.Text = "(...) ";
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 850);
            this.Controls.Add(this.lbl_matricule);
            this.Controls.Add(this.dgv_Notes);
            this.Controls.Add(this.btn_ajout_fiche);
            this.Controls.Add(this.lbl_prenom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Accueil";
            this.Text = "Accueil";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Notes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_prenom;
        private System.Windows.Forms.Button btn_ajout_fiche;
        private System.Windows.Forms.DataGridView dgv_Notes;
        private System.Windows.Forms.Label lbl_matricule;
    }
}