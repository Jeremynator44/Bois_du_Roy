namespace Bois_du_Rois
{
    partial class Compte
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
            this.lbl_compte = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_prenom = new System.Windows.Forms.TextBox();
            this.txt_dateNaiss = new System.Windows.Forms.TextBox();
            this.txt_matricule = new System.Windows.Forms.TextBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_responsable = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_compte
            // 
            this.lbl_compte.AutoSize = true;
            this.lbl_compte.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_compte.Location = new System.Drawing.Point(364, 148);
            this.lbl_compte.Name = "lbl_compte";
            this.lbl_compte.Size = new System.Drawing.Size(587, 58);
            this.lbl_compte.TabIndex = 24;
            this.lbl_compte.Text = "Informations du Compte :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(453, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 48);
            this.label1.TabIndex = 25;
            this.label1.Text = "Prénom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label2.Location = new System.Drawing.Point(356, 599);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 48);
            this.label2.TabIndex = 26;
            this.label2.Text = "Responsable :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label3.Location = new System.Drawing.Point(248, 514);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(394, 48);
            this.label3.TabIndex = 27;
            this.label3.Text = "Date de Naissance :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label4.Location = new System.Drawing.Point(428, 433);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 48);
            this.label4.TabIndex = 28;
            this.label4.Text = "Matricule :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label5.Location = new System.Drawing.Point(511, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 48);
            this.label5.TabIndex = 29;
            this.label5.Text = "Nom :";
            // 
            // txt_prenom
            // 
            this.txt_prenom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_prenom.Enabled = false;
            this.txt_prenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prenom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_prenom.Location = new System.Drawing.Point(685, 286);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.ReadOnly = true;
            this.txt_prenom.Size = new System.Drawing.Size(617, 38);
            this.txt_prenom.TabIndex = 30;
            this.txt_prenom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_dateNaiss
            // 
            this.txt_dateNaiss.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_dateNaiss.Enabled = false;
            this.txt_dateNaiss.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dateNaiss.Location = new System.Drawing.Point(685, 524);
            this.txt_dateNaiss.MaxLength = 8;
            this.txt_dateNaiss.Name = "txt_dateNaiss";
            this.txt_dateNaiss.ReadOnly = true;
            this.txt_dateNaiss.Size = new System.Drawing.Size(617, 38);
            this.txt_dateNaiss.TabIndex = 31;
            this.txt_dateNaiss.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_matricule
            // 
            this.txt_matricule.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_matricule.Enabled = false;
            this.txt_matricule.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matricule.Location = new System.Drawing.Point(685, 443);
            this.txt_matricule.Name = "txt_matricule";
            this.txt_matricule.ReadOnly = true;
            this.txt_matricule.Size = new System.Drawing.Size(617, 38);
            this.txt_matricule.TabIndex = 32;
            this.txt_matricule.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_nom
            // 
            this.txt_nom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nom.Enabled = false;
            this.txt_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nom.Location = new System.Drawing.Point(685, 367);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.ReadOnly = true;
            this.txt_nom.Size = new System.Drawing.Size(617, 38);
            this.txt_nom.TabIndex = 33;
            this.txt_nom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_responsable
            // 
            this.txt_responsable.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_responsable.Enabled = false;
            this.txt_responsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_responsable.Location = new System.Drawing.Point(685, 609);
            this.txt_responsable.Name = "txt_responsable";
            this.txt_responsable.ReadOnly = true;
            this.txt_responsable.Size = new System.Drawing.Size(617, 38);
            this.txt_responsable.TabIndex = 34;
            this.txt_responsable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Compte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 850);
            this.Controls.Add(this.txt_responsable);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.txt_matricule);
            this.Controls.Add(this.txt_dateNaiss);
            this.Controls.Add(this.txt_prenom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_compte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Compte";
            this.Text = "Compte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_compte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_prenom;
        private System.Windows.Forms.TextBox txt_dateNaiss;
        private System.Windows.Forms.TextBox txt_matricule;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_responsable;
    }
}