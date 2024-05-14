namespace Bois_du_Rois
{
    partial class Ajout_Produit
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
            this.lbl_message_info_produit = new System.Windows.Forms.Label();
            this.txt_type_produit = new System.Windows.Forms.TextBox();
            this.txt_code_produit = new System.Windows.Forms.TextBox();
            this.lbl_type_produit = new System.Windows.Forms.Label();
            this.lbl_code_produit = new System.Windows.Forms.Label();
            this.btn_Confirm_Ajout = new System.Windows.Forms.Button();
            this.btn_Annulation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_message_info_produit
            // 
            this.lbl_message_info_produit.AutoSize = true;
            this.lbl_message_info_produit.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_message_info_produit.Location = new System.Drawing.Point(497, 109);
            this.lbl_message_info_produit.Name = "lbl_message_info_produit";
            this.lbl_message_info_produit.Size = new System.Drawing.Size(327, 42);
            this.lbl_message_info_produit.TabIndex = 61;
            this.lbl_message_info_produit.Text = "Ajout d\'un produit :";
            // 
            // txt_type_produit
            // 
            this.txt_type_produit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_type_produit.Location = new System.Drawing.Point(883, 312);
            this.txt_type_produit.Name = "txt_type_produit";
            this.txt_type_produit.Size = new System.Drawing.Size(285, 30);
            this.txt_type_produit.TabIndex = 60;
            this.txt_type_produit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_code_produit
            // 
            this.txt_code_produit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_code_produit.Location = new System.Drawing.Point(883, 243);
            this.txt_code_produit.Name = "txt_code_produit";
            this.txt_code_produit.Size = new System.Drawing.Size(285, 30);
            this.txt_code_produit.TabIndex = 59;
            this.txt_code_produit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_type_produit
            // 
            this.lbl_type_produit.AutoSize = true;
            this.lbl_type_produit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_type_produit.Location = new System.Drawing.Point(609, 306);
            this.lbl_type_produit.Name = "lbl_type_produit";
            this.lbl_type_produit.Size = new System.Drawing.Size(242, 36);
            this.lbl_type_produit.TabIndex = 58;
            this.lbl_type_produit.Text = "Type de Produit :";
            // 
            // lbl_code_produit
            // 
            this.lbl_code_produit.AutoSize = true;
            this.lbl_code_produit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_code_produit.Location = new System.Drawing.Point(645, 237);
            this.lbl_code_produit.Name = "lbl_code_produit";
            this.lbl_code_produit.Size = new System.Drawing.Size(206, 36);
            this.lbl_code_produit.TabIndex = 57;
            this.lbl_code_produit.Text = "Code Produit :";
            // 
            // btn_Confirm_Ajout
            // 
            this.btn_Confirm_Ajout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Confirm_Ajout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Confirm_Ajout.BackColor = System.Drawing.Color.Black;
            this.btn_Confirm_Ajout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Confirm_Ajout.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_Confirm_Ajout.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_Confirm_Ajout.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_Confirm_Ajout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Confirm_Ajout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Confirm_Ajout.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Confirm_Ajout.Location = new System.Drawing.Point(978, 439);
            this.btn_Confirm_Ajout.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Confirm_Ajout.Name = "btn_Confirm_Ajout";
            this.btn_Confirm_Ajout.Size = new System.Drawing.Size(216, 50);
            this.btn_Confirm_Ajout.TabIndex = 68;
            this.btn_Confirm_Ajout.Text = "Confirmer l\'Ajout";
            this.btn_Confirm_Ajout.UseVisualStyleBackColor = false;
            this.btn_Confirm_Ajout.Click += new System.EventHandler(this.btn_Confirm_Ajout_Click);
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
            this.btn_Annulation.Location = new System.Drawing.Point(726, 439);
            this.btn_Annulation.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Annulation.Name = "btn_Annulation";
            this.btn_Annulation.Size = new System.Drawing.Size(160, 50);
            this.btn_Annulation.TabIndex = 67;
            this.btn_Annulation.Text = "Annuler";
            this.btn_Annulation.UseVisualStyleBackColor = false;
            this.btn_Annulation.Click += new System.EventHandler(this.btn_Annulation_Click);
            // 
            // Ajout_Produit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 850);
            this.Controls.Add(this.btn_Confirm_Ajout);
            this.Controls.Add(this.btn_Annulation);
            this.Controls.Add(this.lbl_message_info_produit);
            this.Controls.Add(this.txt_type_produit);
            this.Controls.Add(this.txt_code_produit);
            this.Controls.Add(this.lbl_type_produit);
            this.Controls.Add(this.lbl_code_produit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ajout_Produit";
            this.Text = "Ajout_Produit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_message_info_produit;
        private System.Windows.Forms.TextBox txt_type_produit;
        private System.Windows.Forms.TextBox txt_code_produit;
        private System.Windows.Forms.Label lbl_type_produit;
        private System.Windows.Forms.Label lbl_code_produit;
        private System.Windows.Forms.Button btn_Confirm_Ajout;
        private System.Windows.Forms.Button btn_Annulation;
    }
}