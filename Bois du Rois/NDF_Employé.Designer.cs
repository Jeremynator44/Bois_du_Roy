namespace Bois_du_Rois
{
    partial class NDF_Employé
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
            this.btn_ajout_fiche = new System.Windows.Forms.Button();
            this.dgv_Notes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Notes)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ajout_fiche
            // 
            this.btn_ajout_fiche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.btn_ajout_fiche.FlatAppearance.BorderSize = 0;
            this.btn_ajout_fiche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ajout_fiche.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajout_fiche.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ajout_fiche.Location = new System.Drawing.Point(154, 235);
            this.btn_ajout_fiche.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ajout_fiche.Name = "btn_ajout_fiche";
            this.btn_ajout_fiche.Size = new System.Drawing.Size(361, 52);
            this.btn_ajout_fiche.TabIndex = 36;
            this.btn_ajout_fiche.Text = "+ Ajouter une nouvelle fiche";
            this.btn_ajout_fiche.UseVisualStyleBackColor = false;
            // 
            // dgv_Notes
            // 
            this.dgv_Notes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_Notes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Notes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Notes.Location = new System.Drawing.Point(154, 303);
            this.dgv_Notes.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Notes.Name = "dgv_Notes";
            this.dgv_Notes.RowHeadersWidth = 51;
            this.dgv_Notes.Size = new System.Drawing.Size(1493, 480);
            this.dgv_Notes.TabIndex = 38;
            // 
            // NDF_Employé
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 850);
            this.Controls.Add(this.dgv_Notes);
            this.Controls.Add(this.btn_ajout_fiche);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NDF_Employé";
            this.Text = "NDF_Employé";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Notes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_ajout_fiche;
        private System.Windows.Forms.DataGridView dgv_Notes;
    }
}