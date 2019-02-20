using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Domain;

namespace App
{
    public partial class MainForm : Form
    {
        private AppMethods Methods;
        private bool isConnected;

        public MainForm(IUtilisateurRepository utilisateurRepository, ICoureurRepository coureurRepository, ICourseRepository courseRepository, IParticipationRepository participationRepository)
        {
            
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Methods = new AppMethods(utilisateurRepository, coureurRepository, courseRepository, participationRepository);
            Methods.RefreshContenuCoureurs(dgvCoureurs);
            Methods.RefreshContenuCourses(dgvCourses);
            btnCoursesReinit.Visible = false;
            dgvParticipationsNameCoureurs.Visible = false;
            dgvParticipationsNameCourse.Visible = false;
            btnDeleteCoureur.Visible = false;
            btnDeleteCourse.Visible = false;
            isConnected = false;
            lblSearchByAge.Visible = false;

    }


        //BUTTON CONTROLS
        private void btnCoureursRecherche_Click(object sender, EventArgs e)
        {
            Methods.Search(tbCoureursRecherche.Text, dgvCoureurs, dgvParticipationsNameCoureurs, btnCoureursRecherche, btnCoureursReinit, btnDeleteCoureur, isConnected);

        }

        private void btnCoursesRecherche_Click(object sender, EventArgs e)
        {
            Methods.Search(tbCoursesRecherche.Text, dgvCourses, dgvParticipationsNameCourse, btnCoursesRecherche, btnCoursesReinit, btnDeleteCourse, isConnected);
            if (isConnected)
            {
                btnCoureurImport.Visible = true;
                btnCourseImport.Visible = true;
            }
        }

        private void btnCoureursReinit_Click(object sender, EventArgs e)
        {
            Methods.RefreshContenuCoureurs(dgvCoureurs);
            dgvParticipationsNameCoureurs.Visible = false;
            dgvCoureurs.Visible = true;
            btnCoureursRecherche.Visible = true;
            btnCoureursReinit.Visible = false;
            tbCoureursRecherche.Text = "";
            btnDeleteCoureur.Visible = false;
        }

        private void btnCoursesReinit_Click(object sender, EventArgs e)
        {
            Methods.RefreshContenuCourses(dgvCourses);
            dgvParticipationsNameCourse.Visible = false;
            dgvCourses.Visible = true;
            btnCoursesReinit.Visible = false;
            btnCoursesRecherche.Visible = true;
            cbRangeAge.Visible = false;
            lblSearchByAge.Visible = false;
            tbCoursesRecherche.Text = "";
            btnDeleteCourse.Visible = false;
            if (isConnected)
            {
                btnCoureurImport.Visible = false;
                btnCourseImport.Visible = false;
            }
        }

        private void btnCoureurImport_Click(object sender, EventArgs e)
        {
            Methods.ImportCSVCoureur(this.tbCoursesRecherche.Text, dgvCoureurs, dgvParticipationsNameCourse, dgvCourses, btnCoursesRecherche, btnCoursesReinit, btnDeleteCoureur, isConnected);
        }

        private void btnCourseImport_Click(object sender, EventArgs e)
        {
            Methods.ImportCSVCourse(dgvCoureurs, dgvParticipationsNameCourse, dgvCourses, btnCoursesRecherche, btnCoursesReinit, btnDeleteCourse, isConnected);
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            ConnectionForm formConnexion = new ConnectionForm(Methods.GetUtilisateurRepository());
            DialogResult connectionResult = formConnexion.ShowDialog();
            if (connectionResult == DialogResult.OK)
            {
                isConnected = formConnexion.IsConnected;

                btnConnexion.Visible = false;
                lbConnected.Visible = true;
                btnAddCourse.Visible = true;
                if (dgvParticipationsNameCourse.Visible == true) {
                    btnDeleteCourse.Visible = true;
                    btnCoureurImport.Visible = true;
                    btnCourseImport.Visible = true;
                }
            }
        }

        private void btnDeleteCoureur_Click(object sender, EventArgs e)
        {
            
            Methods.DeleteCoureur(tbCoureursRecherche.Text);
            Methods.RefreshContenuCoureurs(dgvCoureurs);
            dgvParticipationsNameCoureurs.Visible = false;
            dgvCoureurs.Visible = true;
            dgvCoureurs.Visible = true;
            btnCoureursRecherche.Visible = true;
            btnCoureursReinit.Visible = true;
            tbCoureursRecherche.Text = "";
            btnDeleteCoureur.Visible = false;

        }

        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            Methods.DeleteCourse(tbCoursesRecherche.Text);
            Methods.RefreshContenuCourses(dgvCourses);
            dgvParticipationsNameCourse.Visible = false;
            dgvCourses.Visible = true;
            btnCoursesReinit.Visible = false;
            btnCoursesRecherche.Visible = true;
            cbRangeAge.Visible = false;
            lblSearchByAge.Visible = false;
            tbCoursesRecherche.Text = "";
            btnDeleteCourse.Visible = false;
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            AddCourseForm addCourseForm = new AddCourseForm();
            DialogResult addCourseResult = addCourseForm.ShowDialog();
            if (addCourseResult == DialogResult.OK)
            {
                Methods.AddCourse(addCourseForm.NameCourse, addCourseForm.NbKm, addCourseForm.TypeCourse, dgvCourses);
            }
        }


        //DGV INTERACTIONS
        private void dgvCourses_RowHeaderMouseDoubleClick(object sender, EventArgs e)
        {
            Methods.Search(this.dgvCourses.SelectedRows[0].Cells[1].Value.ToString(), dgvCourses, dgvParticipationsNameCourse, btnCoursesRecherche, btnCoursesReinit, btnDeleteCourse, isConnected);
            cbRangeAge.Visible = true;
            lblSearchByAge.Visible = true;
            tbCoursesRecherche.Text = this.dgvCourses.SelectedRows[0].Cells[1].Value.ToString();
            if (isConnected)
            {
                btnCoureurImport.Visible = true;
                btnCourseImport.Visible = true;
            }

        }

        private void dgvCoureurs_RowHeaderMouseDoubleClick(object sender, EventArgs e)
        {
            Methods.Search(this.dgvCoureurs.SelectedRows[0].Cells[0].Value.ToString(), dgvCoureurs, dgvParticipationsNameCoureurs, btnCoureursRecherche, btnCoureursReinit, btnDeleteCoureur, isConnected);
            tbCoureursRecherche.Text = this.dgvCoureurs.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void dgvParticipationsNameCourse_RowHeaderMouseDoubleClick(object sender, EventArgs e)
        {
            Methods.Search(this.dgvParticipationsNameCourse.SelectedRows[0].Cells[5].Value.ToString().Split(' ')[0], dgvCoureurs, dgvParticipationsNameCoureurs, btnCoureursRecherche, btnCoureursReinit, btnDeleteCoureur, isConnected);
            tcMain.SelectedTab = tabCoureurs;
            if (isConnected)
            {
                btnCoureurImport.Visible = false;
                btnCourseImport.Visible = false;
            }
        }
        
        private void dgvParticipationsNameCoureurs_RowHeaderMouseDoubleClick(object sender, EventArgs e)
        {
            Methods.Search(this.dgvParticipationsNameCoureurs.SelectedRows[0].Cells[7].Value.ToString(), dgvCourses, dgvParticipationsNameCourse, btnCoursesRecherche, btnCoursesReinit, btnDeleteCoureur, isConnected);
            tcMain.SelectedTab = tabCourses;
        }


        //MISC
        private void cbRangeAge_SelectedIndexChanged(object sender, EventArgs e)
        {
            Methods.RangeSearch(cbRangeAge.SelectedIndex, this.tbCoursesRecherche.Text, dgvParticipationsNameCourse);
        }

        private void dgvParticipationsNameCoureurs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result2 = MessageBox.Show("Êtes vous sûr de vouloir quitter l'application ?",
                "Important Query",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result2 == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void lbHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Pour les coureurs, vous pouvez rechercher un coureur grâce à la recherche, mais également en cliquant sur la tête de ligne correspondant au coureur. Vous obtiendrez alors l'ensemble de ses participations. Pour les courses, vous pouvez effectuer la même recherche. Une fois cette recherche effectuée, vous pouvez recliquer sur une tête de ligne correspondant à un coureur pour retomber sur ses participations. Seuls les administrateurs possèdent les droits de modification. Toutes ces opérations sont guidées par les différents boutons. ",
            "Important Message");
        }
    }
}
