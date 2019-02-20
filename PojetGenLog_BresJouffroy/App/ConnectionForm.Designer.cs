namespace App
{
    partial class ConnectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionForm));
            this.tbEmailConnexion = new System.Windows.Forms.TextBox();
            this.tbMdpConnexion = new System.Windows.Forms.TextBox();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.lbPasDeCompte = new System.Windows.Forms.LinkLabel();
            this.lbPseudo = new System.Windows.Forms.Label();
            this.lbMdp = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tbEmailConnexion
            // 
            this.tbEmailConnexion.Location = new System.Drawing.Point(153, 243);
            this.tbEmailConnexion.Name = "tbEmailConnexion";
            this.tbEmailConnexion.Size = new System.Drawing.Size(312, 20);
            this.tbEmailConnexion.TabIndex = 0;
            // 
            // tbMdpConnexion
            // 
            this.tbMdpConnexion.Location = new System.Drawing.Point(153, 312);
            this.tbMdpConnexion.Name = "tbMdpConnexion";
            this.tbMdpConnexion.Size = new System.Drawing.Size(312, 20);
            this.tbMdpConnexion.TabIndex = 1;
            // 
            // btnConnexion
            // 
            this.btnConnexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConnexion.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnexion.ForeColor = System.Drawing.Color.White;
            this.btnConnexion.Location = new System.Drawing.Point(217, 372);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(166, 40);
            this.btnConnexion.TabIndex = 2;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.UseVisualStyleBackColor = false;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // lbPasDeCompte
            // 
            this.lbPasDeCompte.AutoSize = true;
            this.lbPasDeCompte.LinkColor = System.Drawing.Color.Black;
            this.lbPasDeCompte.Location = new System.Drawing.Point(223, 457);
            this.lbPasDeCompte.Name = "lbPasDeCompte";
            this.lbPasDeCompte.Size = new System.Drawing.Size(151, 13);
            this.lbPasDeCompte.TabIndex = 3;
            this.lbPasDeCompte.TabStop = true;
            this.lbPasDeCompte.Text = "Retourner au site sans compte";
            this.lbPasDeCompte.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbPasDeCompte_LinkClicked);
            // 
            // lbPseudo
            // 
            this.lbPseudo.AutoSize = true;
            this.lbPseudo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPseudo.Location = new System.Drawing.Point(150, 214);
            this.lbPseudo.Name = "lbPseudo";
            this.lbPseudo.Size = new System.Drawing.Size(70, 17);
            this.lbPseudo.TabIndex = 4;
            this.lbPseudo.Text = "Pseudo : ";
            // 
            // lbMdp
            // 
            this.lbMdp.AutoSize = true;
            this.lbMdp.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMdp.Location = new System.Drawing.Point(150, 292);
            this.lbMdp.Name = "lbMdp";
            this.lbMdp.Size = new System.Drawing.Size(103, 17);
            this.lbMdp.TabIndex = 5;
            this.lbMdp.Text = "Mot de passe :";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbTitle.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(172, 111);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(270, 17);
            this.lbTitle.TabIndex = 6;
            this.lbTitle.Text = "Votre gestionnaire de courses pedestres";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(615, 148);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(258, -7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(125, 115);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // ConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(614, 502);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.lbMdp);
            this.Controls.Add(this.lbPseudo);
            this.Controls.Add(this.lbPasDeCompte);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.tbMdpConnexion);
            this.Controls.Add(this.tbEmailConnexion);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ConnectionForm";
            this.Text = "Connexion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbEmailConnexion;
        private System.Windows.Forms.TextBox tbMdpConnexion;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.LinkLabel lbPasDeCompte;
        private System.Windows.Forms.Label lbPseudo;
        private System.Windows.Forms.Label lbMdp;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}