using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class ImportCoureurForm : Form
    {
        public int Dossard { get; private set; }

        public ImportCoureurForm(string nom, string prenom, string courseName)
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            lblInstructions.Text = "Renseignez le dossard de " + nom + " " + prenom + " pour la course " + courseName + ".";
        }

        private void btnEnvoyer_Click(object sender, EventArgs e)
        {
            try
            {
                this.Dossard = Convert.ToInt32(tbDossardInput.Text);
            }
            catch
            {
                MessageBox.Show("Il semblerait qu'il ne s'agisse pas d'un chiffre entier, veuillez remplir à nouveau le dossard.");
                return;
            }
            if (tbDossardInput.Text == "")
            {
                MessageBox.Show("Il semblerait qu'il ne s'agisse pas d'un chiffre entier, veuillez remplir à nouveau le dossard.");
                return;
            }

            this.DialogResult = DialogResult.OK;
        }
    }
}
