namespace Bois_du_Rois
{
    partial class Modif_Produit
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
            this.lbl_message_info_produit = new System.Windows.Forms.Label();
            this.txt_type_produit = new System.Windows.Forms.TextBox();
            this.txt_code_produit = new System.Windows.Forms.TextBox();
            this.lbl_type_produit = new System.Windows.Forms.Label();
            this.lbl_code_produit = new System.Windows.Forms.Label();
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
            this.btn_Confirm_Modif.Location = new System.Drawing.Point(999, 450);
            this.btn_Confirm_Modif.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Confirm_Modif.Name = "btn_Confirm_Modif";
            this.btn_Confirm_Modif.Size = new System.Drawing.Size(216, 50);
            this.btn_Confirm_Modif.TabIndex = 75;
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
            this.btn_Annulation.Location = new System.Drawing.Point(747, 450);
            this.btn_Annulation.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Annulation.Name = "btn_Annulation";
            this.btn_Annulation.Size = new System.Drawing.Size(160, 50);
            this.btn_Annulation.TabIndex = 74;
            this.btn_Annulation.Text = "Annuler";
            this.btn_Annulation.UseVisualStyleBackColor = false;
            this.btn_Annulation.Click += new System.EventHandler(this.btn_Annulation_Click);
            // 
            // lbl_message_info_produit
            // 
            this.lbl_message_info_produit.AutoSize = true;
            this.lbl_message_info_produit.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_message_info_produit.Location = new System.Drawing.Point(518, 120);
            this.lbl_message_info_produit.Name = "lbl_message_info_produit";
            this.lbl_message_info_produit.Size = new System.Drawing.Size(441, 42);
            this.lbl_message_info_produit.TabIndex = 73;
            this.lbl_message_info_produit.Text = "Modification d\'un produit :";
            // 
            // txt_type_produit
            // 
            this.txt_type_produit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_type_produit.Location = new System.Drawing.Point(904, 323);
            this.txt_type_produit.Name = "txt_type_produit";
            this.txt_type_produit.Size = new System.Drawing.Size(285, 30);
            this.txt_type_produit.TabIndex = 72;
            this.txt_type_produit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_code_produit
            // 
            this.txt_code_produit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_code_produit.Location = new System.Drawing.Point(904, 254);
            this.txt_code_produit.Name = "txt_code_produit";
            this.txt_code_produit.Size = new System.Drawing.Size(285, 30);
            this.txt_code_produit.TabIndex = 71;
            this.txt_code_produit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_type_produit
            // 
            this.lbl_type_produit.AutoSize = true;
            this.lbl_type_produit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_type_produit.Location = new System.Drawing.Point(630, 317);
            this.lbl_type_produit.Name = "lbl_type_produit";
            this.lbl_type_produit.Size = new System.Drawing.Size(242, 36);
            this.lbl_type_produit.TabIndex = 70;
            this.lbl_type_produit.Text = "Type de Produit :";
            // 
            // lbl_code_produit
            // 
            this.lbl_code_produit.AutoSize = true;
            this.lbl_code_produit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_code_produit.Location = new System.Drawing.Point(666, 248);
            this.lbl_code_produit.Name = "lbl_code_produit";
            this.lbl_code_produit.Size = new System.Drawing.Size(206, 36);
            this.lbl_code_produit.TabIndex = 69;
            this.lbl_code_produit.Text = "Code Produit :";
            // 
            // Modif_Produit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 850);
            this.Controls.Add(this.btn_Confirm_Modif);
            this.Controls.Add(this.btn_Annulation);
            this.Controls.Add(this.lbl_message_info_produit);
            this.Controls.Add(this.txt_type_produit);
            this.Controls.Add(this.txt_code_produit);
            this.Controls.Add(this.lbl_type_produit);
            this.Controls.Add(this.lbl_code_produit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Modif_Produit";
            this.Text = "Modif_Produit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Confirm_Modif;
        private System.Windows.Forms.Button btn_Annulation;
        private System.Windows.Forms.Label lbl_message_info_produit;
        private System.Windows.Forms.TextBox txt_type_produit;
        private System.Windows.Forms.TextBox txt_code_produit;
        private System.Windows.Forms.Label lbl_type_produit;
        private System.Windows.Forms.Label lbl_code_produit;
    }
}