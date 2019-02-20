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
    public partial class AddCourseForm : Form
    {
        public string NameCourse { get; private set; }
        public string TypeCourse { get; private set; }
        public int NbKm { get; private set; }


        public AddCourseForm()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

        }

        private void btnEnvoyer_Click(object sender, EventArgs e)
        {
            try
            {
                this.NbKm = Convert.ToInt32(tbNbKm.Text);
            }
            catch
            {
                MessageBox.Show("Il semblerait que ce le nombre de kilomètre pas d'un nombre entier, veuillez remplir à nouveau la valeur.");
                return;
            }
            if ((tbCourseName.Text == "") || (tbNbKm.Text == "") || (tbTypeCourse.Text == ""))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }

            this.NameCourse = tbCourseName.Text;
            this.TypeCourse = tbTypeCourse.Text;

            this.DialogResult = DialogResult.OK;
        }
    }
}
