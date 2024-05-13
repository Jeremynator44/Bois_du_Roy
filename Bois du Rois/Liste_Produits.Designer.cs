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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Liste_Produits));
            this.lbl_liste_employes = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_exporter = new System.Windows.Forms.Button();
            this.dgv_Liste_Produits = new System.Windows.Forms.DataGridView();
            this.btn_copier = new System.Windows.Forms.Button();
            this.btn_ajout_fiche = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Liste_Produits)).BeginInit();
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
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1355, 237);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 50);
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // btn_exporter
            // 
            this.btn_exporter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.btn_exporter.FlatAppearance.BorderSize = 0;
            this.btn_exporter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exporter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exporter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_exporter.Location = new System.Drawing.Point(1445, 237);
            this.btn_exporter.Margin = new System.Windows.Forms.Padding(4);
            this.btn_exporter.Name = "btn_exporter";
            this.btn_exporter.Size = new System.Drawing.Size(199, 52);
            this.btn_exporter.TabIndex = 50;
            this.btn_exporter.Text = "Exporter";
            this.btn_exporter.UseVisualStyleBackColor = false;
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
            // btn_copier
            // 
            this.btn_copier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.btn_copier.FlatAppearance.BorderSize = 0;
            this.btn_copier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_copier.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_copier.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_copier.Location = new System.Drawing.Point(568, 237);
            this.btn_copier.Margin = new System.Windows.Forms.Padding(4);
            this.btn_copier.Name = "btn_copier";
            this.btn_copier.Size = new System.Drawing.Size(199, 52);
            this.btn_copier.TabIndex = 48;
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
            this.btn_ajout_fiche.Location = new System.Drawing.Point(151, 237);
            this.btn_ajout_fiche.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ajout_fiche.Name = "btn_ajout_fiche";
            this.btn_ajout_fiche.Size = new System.Drawing.Size(361, 52);
            this.btn_ajout_fiche.TabIndex = 47;
            this.btn_ajout_fiche.Text = "+ Ajouter une nouvelle fiche";
            this.btn_ajout_fiche.UseVisualStyleBackColor = false;
            // 
            // Liste_Produits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 850);
            this.Controls.Add(this.lbl_liste_employes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_exporter);
            this.Controls.Add(this.dgv_Liste_Produits);
            this.Controls.Add(this.btn_copier);
            this.Controls.Add(this.btn_ajout_fiche);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Liste_Produits";
            this.Text = "Liste_Produits";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Liste_Produits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_liste_employes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_exporter;
        private System.Windows.Forms.DataGridView dgv_Liste_Produits;
        private System.Windows.Forms.Button btn_copier;
        private System.Windows.Forms.Button btn_ajout_fiche;
    }
}