namespace Bois_du_Rois
{
    partial class Modif_Employé
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
            this.btn_Confirm_Modif = new System.Windows.Forms.Button();
            this.btn_Annulation = new System.Windows.Forms.Button();
            this.lbl_message_info_employé = new System.Windows.Forms.Label();
            this.txt_prenom = new System.Windows.Forms.TextBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.lbl_prenom = new System.Windows.Forms.Label();
            this.txt_matricule = new System.Windows.Forms.TextBox();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.lbl_matricule = new System.Windows.Forms.Label();
            this.txt_dateEntree = new System.Windows.Forms.TextBox();
            this.txt_dateNaiss = new System.Windows.Forms.TextBox();
            this.lbl_date_entree = new System.Windows.Forms.Label();
            this.lbl_naiss = new System.Windows.Forms.Label();
            this.lbl_date_sortie = new System.Windows.Forms.Label();
            this.txt_dateSortie = new System.Windows.Forms.TextBox();
            this.lbl_responsable = new System.Windows.Forms.Label();
            this.txt_responsable = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Confirm_Modif
            // 
            this.btn_Confirm_Modif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Confirm_Modif.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Confirm_Modif.BackColor = System.Drawing.Color.Black;
            this.btn_Confirm_Modif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Confirm_Modif.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_Confirm_Modif.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_Confirm_Modif.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_Confirm_Modif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Confirm_Modif.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Confirm_Modif.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Confirm_Modif.Location = new System.Drawing.Point(978, 671);
            this.btn_Confirm_Modif.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Confirm_Modif.Name = "btn_Confirm_Modif";
            this.btn_Confirm_Modif.Size = new System.Drawing.Size(216, 50);
            this.btn_Confirm_Modif.TabIndex = 41;
            this.btn_Confirm_Modif.Text = "Confirmer la Modification";
            this.btn_Confirm_Modif.UseVisualStyleBackColor = false;
            this.btn_Confirm_Modif.Click += new System.EventHandler(this.btn_Confirm_Modif_Click);
            // 
            // btn_Annulation
            // 
            this.btn_Annulation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Annulation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Annulation.BackColor = System.Drawing.Color.Black;
            this.btn_Annulation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Annulation.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_Annulation.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_Annulation.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_Annulation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Annulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Annulation.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Annulation.Location = new System.Drawing.Point(726, 671);
            this.btn_Annulation.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Annulation.Name = "btn_Annulation";
            this.btn_Annulation.Size = new System.Drawing.Size(160, 50);
            this.btn_Annulation.TabIndex = 40;
            this.btn_Annulation.Text = "Annuler";
            this.btn_Annulation.UseVisualStyleBackColor = false;
            this.btn_Annulation.Click += new System.EventHandler(this.btn_Annulation_Click);
            // 
            // lbl_message_info_employé
            // 
            this.lbl_message_info_employé.AutoSize = true;
            this.lbl_message_info_employé.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_message_info_employé.Location = new System.Drawing.Point(477, 76);
            this.lbl_message_info_employé.Name = "lbl_message_info_employé";
            this.lbl_message_info_employé.Size = new System.Drawing.Size(468, 42);
            this.lbl_message_info_employé.TabIndex = 39;
            this.lbl_message_info_employé.Text = "Modification d\'un employé :";
            // 
            // txt_prenom
            // 
            this.txt_prenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prenom.Location = new System.Drawing.Point(863, 339);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.Size = new System.Drawing.Size(285, 30);
            this.txt_prenom.TabIndex = 38;
            this.txt_prenom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_nom
            // 
            this.txt_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nom.Location = new System.Drawing.Point(863, 268);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(285, 30);
            this.txt_nom.TabIndex = 37;
            this.txt_nom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_prenom
            // 
            this.lbl_prenom.AutoSize = true;
            this.lbl_prenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prenom.Location = new System.Drawing.Point(664, 333);
            this.lbl_prenom.Name = "lbl_prenom";
            this.lbl_prenom.Size = new System.Drawing.Size(134, 36);
            this.lbl_prenom.TabIndex = 36;
            this.lbl_prenom.Text = "Prénom :";
            // 
            // txt_matricule
            // 
            this.txt_matricule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matricule.Location = new System.Drawing.Point(863, 199);
            this.txt_matricule.Name = "txt_matricule";
            this.txt_matricule.Size = new System.Drawing.Size(285, 30);
            this.txt_matricule.TabIndex = 35;
            this.txt_matricule.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nom.Location = new System.Drawing.Point(705, 262);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(93, 36);
            this.lbl_nom.TabIndex = 34;
            this.lbl_nom.Text = "Nom :";
            // 
            // lbl_matricule
            // 
            this.lbl_matricule.AutoSize = true;
            this.lbl_matricule.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_matricule.Location = new System.Drawing.Point(646, 193);
            this.lbl_matricule.Name = "lbl_matricule";
            this.lbl_matricule.Size = new System.Drawing.Size(152, 36);
            this.lbl_matricule.TabIndex = 33;
            this.lbl_matricule.Text = "Matricule :";
            // 
            // txt_dateEntree
            // 
            this.txt_dateEntree.Enabled = false;
            this.txt_dateEntree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dateEntree.Location = new System.Drawing.Point(863, 480);
            this.txt_dateEntree.Name = "txt_dateEntree";
            this.txt_dateEntree.ReadOnly = true;
            this.txt_dateEntree.Size = new System.Drawing.Size(285, 30);
            this.txt_dateEntree.TabIndex = 45;
            this.txt_dateEntree.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_dateNaiss
            // 
            this.txt_dateNaiss.Enabled = false;
            this.txt_dateNaiss.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dateNaiss.Location = new System.Drawing.Point(484, 480);
            this.txt_dateNaiss.Name = "txt_dateNaiss";
            this.txt_dateNaiss.ReadOnly = true;
            this.txt_dateNaiss.Size = new System.Drawing.Size(285, 30);
            this.txt_dateNaiss.TabIndex = 44;
            this.txt_dateNaiss.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_date_entree
            // 
            this.lbl_date_entree.AutoSize = true;
            this.lbl_date_entree.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date_entree.Location = new System.Drawing.Point(899, 419);
            this.lbl_date_entree.Name = "lbl_date_entree";
            this.lbl_date_entree.Size = new System.Drawing.Size(194, 36);
            this.lbl_date_entree.TabIndex = 43;
            this.lbl_date_entree.Text = "Date d\'Entrée";
            // 
            // lbl_naiss
            // 
            this.lbl_naiss.AutoSize = true;
            this.lbl_naiss.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_naiss.Location = new System.Drawing.Point(496, 419);
            this.lbl_naiss.Name = "lbl_naiss";
            this.lbl_naiss.Size = new System.Drawing.Size(264, 36);
            this.lbl_naiss.TabIndex = 42;
            this.lbl_naiss.Text = "Date de Naissance";
            // 
            // lbl_date_sortie
            // 
            this.lbl_date_sortie.AutoSize = true;
            this.lbl_date_sortie.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date_sortie.Location = new System.Drawing.Point(1264, 419);
            this.lbl_date_sortie.Name = "lbl_date_sortie";
            this.lbl_date_sortie.Size = new System.Drawing.Size(203, 36);
            this.lbl_date_sortie.TabIndex = 46;
            this.lbl_date_sortie.Text = "Date de Sortie";
            // 
            // txt_dateSortie
            // 
            this.txt_dateSortie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dateSortie.Location = new System.Drawing.Point(1226, 480);
            this.txt_dateSortie.Name = "txt_dateSortie";
            this.txt_dateSortie.Size = new System.Drawing.Size(285, 30);
            this.txt_dateSortie.TabIndex = 47;
            this.txt_dateSortie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_responsable
            // 
            this.lbl_responsable.AutoSize = true;
            this.lbl_responsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_responsable.Location = new System.Drawing.Point(630, 580);
            this.lbl_responsable.Name = "lbl_responsable";
            this.lbl_responsable.Size = new System.Drawing.Size(206, 36);
            this.lbl_responsable.TabIndex = 48;
            this.lbl_responsable.Text = "Responsable :";
            // 
            // txt_responsable
            // 
            this.txt_responsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_responsable.Location = new System.Drawing.Point(863, 586);
            this.txt_responsable.Name = "txt_responsable";
            this.txt_responsable.Size = new System.Drawing.Size(285, 30);
            this.txt_responsable.TabIndex = 49;
            this.txt_responsable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Modif_Employé
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 850);
            this.Controls.Add(this.txt_responsable);
            this.Controls.Add(this.lbl_responsable);
            this.Controls.Add(this.txt_dateSortie);
            this.Controls.Add(this.lbl_date_sortie);
            this.Controls.Add(this.txt_dateEntree);
            this.Controls.Add(this.txt_dateNaiss);
            this.Controls.Add(this.lbl_date_entree);
            this.Controls.Add(this.lbl_naiss);
            this.Controls.Add(this.btn_Confirm_Modif);
            this.Controls.Add(this.btn_Annulation);
            this.Controls.Add(this.lbl_message_info_employé);
            this.Controls.Add(this.txt_prenom);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.lbl_prenom);
            this.Controls.Add(this.txt_matricule);
            this.Controls.Add(this.lbl_nom);
            this.Controls.Add(this.lbl_matricule);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Modif_Employé";
            this.Text = "Modif_Employé";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Confirm_Modif;
        private System.Windows.Forms.Button btn_Annulation;
        private System.Windows.Forms.Label lbl_message_info_employé;
        private System.Windows.Forms.TextBox txt_prenom;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Label lbl_prenom;
        private System.Windows.Forms.TextBox txt_matricule;
        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.Label lbl_matricule;
        private System.Windows.Forms.TextBox txt_dateEntree;
        private System.Windows.Forms.TextBox txt_dateNaiss;
        private System.Windows.Forms.Label lbl_date_entree;
        private System.Windows.Forms.Label lbl_naiss;
        private System.Windows.Forms.Label lbl_date_sortie;
        private System.Windows.Forms.TextBox txt_dateSortie;
        private System.Windows.Forms.Label lbl_responsable;
        private System.Windows.Forms.TextBox txt_responsable;
    }
}