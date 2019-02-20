namespace App
{
    partial class AddCourseForm
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
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblTypeCourse = new System.Windows.Forms.Label();
            this.lblNomCourse = new System.Windows.Forms.Label();
            this.lblNbKm = new System.Windows.Forms.Label();
            this.tbCourseName = new System.Windows.Forms.TextBox();
            this.tbTypeCourse = new System.Windows.Forms.TextBox();
            this.tbNbKm = new System.Windows.Forms.TextBox();
            this.btnEnvoyer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(23, 26);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(349, 14);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Pour ajouter une course, veuillez renseigner les informations suivantes";
            // 
            // lblTypeCourse
            // 
            this.lblTypeCourse.AutoSize = true;
            this.lblTypeCourse.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeCourse.Location = new System.Drawing.Point(81, 134);
            this.lblTypeCourse.Name = "lblTypeCourse";
            this.lblTypeCourse.Size = new System.Drawing.Size(153, 14);
            this.lblTypeCourse.TabIndex = 1;
            this.lblTypeCourse.Text = "Type de course (marathon, ...)";
            // 
            // lblNomCourse
            // 
            this.lblNomCourse.AutoSize = true;
            this.lblNomCourse.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomCourse.Location = new System.Drawing.Point(81, 76);
            this.lblNomCourse.Name = "lblNomCourse";
            this.lblNomCourse.Size = new System.Drawing.Size(91, 14);
            this.lblNomCourse.TabIndex = 2;
            this.lblNomCourse.Text = "Nom de la course";
            // 
            // lblNbKm
            // 
            this.lblNbKm.AutoSize = true;
            this.lblNbKm.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbKm.Location = new System.Drawing.Point(81, 196);
            this.lblNbKm.Name = "lblNbKm";
            this.lblNbKm.Size = new System.Drawing.Size(187, 14);
            this.lblNbKm.TabIndex = 3;
            this.lblNbKm.Text = "Nombre de kilomètres (nombre entier)";
            // 
            // tbCourseName
            // 
            this.tbCourseName.Location = new System.Drawing.Point(84, 94);
            this.tbCourseName.Name = "tbCourseName";
            this.tbCourseName.Size = new System.Drawing.Size(179, 20);
            this.tbCourseName.TabIndex = 4;
            // 
            // tbTypeCourse
            // 
            this.tbTypeCourse.Location = new System.Drawing.Point(84, 152);
            this.tbTypeCourse.Name = "tbTypeCourse";
            this.tbTypeCourse.Size = new System.Drawing.Size(179, 20);
            this.tbTypeCourse.TabIndex = 5;
            // 
            // tbNbKm
            // 
            this.tbNbKm.Location = new System.Drawing.Point(84, 214);
            this.tbNbKm.Name = "tbNbKm";
            this.tbNbKm.Size = new System.Drawing.Size(179, 20);
            this.tbNbKm.TabIndex = 6;
            // 
            // btnEnvoyer
            // 
            this.btnEnvoyer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEnvoyer.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnvoyer.ForeColor = System.Drawing.Color.White;
            this.btnEnvoyer.Location = new System.Drawing.Point(120, 255);
            this.btnEnvoyer.Name = "btnEnvoyer";
            this.btnEnvoyer.Size = new System.Drawing.Size(101, 35);
            this.btnEnvoyer.TabIndex = 7;
            this.btnEnvoyer.Text = "Envoyer";
            this.btnEnvoyer.UseVisualStyleBackColor = false;
            this.btnEnvoyer.Click += new System.EventHandler(this.btnEnvoyer_Click);
            // 
            // AddCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(371, 333);
            this.Controls.Add(this.btnEnvoyer);
            this.Controls.Add(this.tbNbKm);
            this.Controls.Add(this.tbTypeCourse);
            this.Controls.Add(this.tbCourseName);
            this.Controls.Add(this.lblNbKm);
            this.Controls.Add(this.lblNomCourse);
            this.Controls.Add(this.lblTypeCourse);
            this.Controls.Add(this.lblInstructions);
            this.Name = "AddCourseForm";
            this.Text = "Ajouter une course";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblTypeCourse;
        private System.Windows.Forms.Label lblNomCourse;
        private System.Windows.Forms.Label lblNbKm;
        private System.Windows.Forms.TextBox tbCourseName;
        private System.Windows.Forms.TextBox tbTypeCourse;
        private System.Windows.Forms.TextBox tbNbKm;
        private System.Windows.Forms.Button btnEnvoyer;
    }
}