using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using DAL;
using Domain;

namespace App
{
    class AppMethods
    {
        private IUtilisateurRepository utilisateurRepository;
        private ICourseRepository courseRepository;
        private ICoureurRepository coureurRepository;
        private IParticipationRepository participationRepository;

        public AppMethods(IUtilisateurRepository utilisateurRepository, ICoureurRepository coureurRepository, ICourseRepository courseRepository, IParticipationRepository participationRepository)
        {
            this.utilisateurRepository = utilisateurRepository;
            this.coureurRepository = coureurRepository;
            this.courseRepository = courseRepository;
            this.participationRepository = participationRepository;
        }



        //IMPORT
        /// <summary>
        /// Fonction d'importation des coureurs d'une course, ne permet pas de remplir les résultats de ces coureurs
        /// </summary>
        /// <param name="courseName"></param>
        /// <param name="dgvCoureurs"></param>
        /// <param name="dgvParticipationsNameCourse"></param>
        /// <param name="dgvCourses"></param>
        /// <param name="btnCoursesRecherche"></param>
        /// <param name="btnCoursesReinit"></param>
        /// <param name="btnDelete"></param>
        /// <param name="isConnected"></param>
        internal void ImportCSVCoureur(string courseName, DataGridView dgvCoureurs, DataGridView dgvParticipationsNameCourse, DataGridView dgvCourses, Button btnCoursesRecherche, Button btnCoursesReinit, Button btnDelete, bool isConnected)
        {
            OpenFileDialog filePath = new OpenFileDialog();

            if (filePath.ShowDialog() == DialogResult.OK)
            {
                if (!filePath.FileName.EndsWith(".csv")) { MessageBox.Show("Veuillez sélectionner un fichier .csv."); return; }
                
                //import coureurs
                StreamReader sr = new StreamReader(filePath.FileName);
                List<Coureur> import = new List<Coureur>();

                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(',', ';');
                    string nom = line[0];
                    string prenom = line[1];
                    DateTime dateNaissance = Convert.ToDateTime(line[2]);
                    string sexe = line[3];
                    string courriel = line[4];
                    string licenceFFA = line[5];

                    Coureur coureur = new Coureur(nom, prenom, sexe, courriel, licenceFFA, dateNaissance);
                    import.Add(coureur);
                }
                sr.Close();

                //création dossards
                int[] dossards = new int[import.Count];
                for (int i = 0; i < import.Count; i++)
                {
                    SaveCoureur(import[i]); //faire une vérification que les coureurs importés n'aient pas déjà été importé (--> getall coureurs, boucle foreach du res du getall avec un bool initialisé en false, si coureurImport name && datenaissance == coureur[i] name && datenaissance alors --> coureurImport.IdCoureur == coureurI.IdCoureur et ne pas importer mais faire dossard quand meme)

                    ImportCoureurForm formImport = new ImportCoureurForm(import[i].Nom, import[i].Prenom, courseName);
                    DialogResult importResult = formImport.ShowDialog();
                    if (importResult == DialogResult.OK)
                    {
                        dossards[i] = formImport.Dossard;
                    }
                }

                //ajout participants et dossards à sql Participation
                Course course = courseRepository.GetCourseInstanceFromName(courseName);
                this.AddImportCoureursParticipation(course, dossards, import);

                RefreshContenuCoureurs(dgvCoureurs);
                Search(courseName, dgvCourses, dgvParticipationsNameCourse, btnCoursesRecherche, btnCoursesReinit, btnDelete, isConnected);
            }
        }

        /// <summary>
        /// Fonction d'importation des résultats des coureurs d'une course (les dossards doivent correspondre à des coureurs déjà importés)
        /// </summary>
        /// <param name="dgvCoureurs"></param>
        /// <param name="dgvParticipationsNameCourse"></param>
        /// <param name="dgvCourses"></param>
        /// <param name="btnCoursesRecherche"></param>
        /// <param name="btnCoursesReinit"></param>
        /// <param name="btnDelete"></param>
        /// <param name="isConnected"></param>
        internal void ImportCSVCourse(DataGridView dgvCoureurs, DataGridView dgvParticipationsNameCourse, DataGridView dgvCourses, Button btnCoursesRecherche, Button btnCoursesReinit, Button btnDelete, bool isConnected)
        {
            OpenFileDialog filePath = new OpenFileDialog();
            if (filePath.ShowDialog() == DialogResult.OK)
            {
                if (!filePath.FileName.EndsWith(".csv")) { MessageBox.Show("Veuillez sélectionner un fichier .csv."); return; }
                StreamReader sr = new StreamReader(filePath.FileName);

                string courseName = dgvParticipationsNameCourse.Rows[0].Cells[6].Value.ToString();
                Course course = this.courseRepository.GetCourseInstanceFromName(courseName);
                string[] line;
                double vitesseMoyenne, allureMoyenneDecimal;
                string temps, allureMoyenne;
                int dossardCSV;


                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine().Split(',', ';');

                    dossardCSV = Convert.ToInt32(line[0]);
                    temps = line[1];
                    vitesseMoyenne = Math.Round(course.NbKm / TimeSpan.Parse(temps).TotalHours, 2);

                    allureMoyenneDecimal = 60 / vitesseMoyenne;
                    allureMoyenne = allureMoyenneDecimal.ToString()[0].ToString() + '\'' + (Math.Round((allureMoyenneDecimal - Math.Truncate(allureMoyenneDecimal)) * 60)).ToString() + '"';

                    for (int i = 0; i < dgvParticipationsNameCourse.Rows.Count-1; i++)
                    {
                        int dossardSelectedRow = Convert.ToInt32(dgvParticipationsNameCourse.Rows[i].Cells[0].Value.ToString());
                        if (dossardSelectedRow == dossardCSV) //if dossards sont égaux
                        {
                            int place = 0;
                            string fullNameCoureur = dgvParticipationsNameCourse.Rows[i].Cells[5].Value.ToString();
                            int idCoureur = this.coureurRepository.GetIdCoureurFromNameAndFirstName(fullNameCoureur);

                            this.participationRepository.UpdateParticipationIncomplete(course.IdCourse, idCoureur, vitesseMoyenne, allureMoyenne, temps, place);
                        }
                    }

                }

                sr.Close();
                Search(courseName, dgvCourses, dgvParticipationsNameCourse, btnCoursesRecherche, btnCoursesReinit, btnDelete, isConnected);
                RefreshContenuCoureurs(dgvCoureurs);
            }
        }



        //SQL_ACCESS
        /// <summary>
        /// Recherche d'un coureur ou d'une course à partir du nom de la course
        /// </summary>
        /// <param name="searchValue"></param>
        /// <param name="dgv"></param>
        /// <param name="dgvGoal"></param>
        /// <param name="btnSearch"></param>
        /// <param name="btnReinit"></param>
        /// <param name="btnDelete"></param>
        /// <param name="isConnected"></param>
        internal void Search(string searchValue, DataGridView dgv, DataGridView dgvGoal, Button btnSearch, Button btnReinit, Button btnDelete, bool isConnected)
        {
            int id = 0;
            try
            {
                bool valueResult = false;
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString().ToLower().Equals(searchValue.ToLower()) || row.Cells[1].Value != null && row.Cells[1].Value.ToString().ToLower().Equals(searchValue.ToLower()))
                    {
                        int rowIndex = row.Index;
                        dgv.Rows[rowIndex].Selected = true;
                        if (dgv.Name == "dgvCoureurs")
                        {
                            id = coureurRepository.GetIdCoureurFromName(searchValue);
                            dgvGoal.DataSource = participationRepository.SearchParticipationByCoureurId(id);
                            ColumnsSortingDgvParticipations(dgvGoal);
                            dgvGoal.Visible = true;
                        }
                        else
                        {
                            id = courseRepository.GetIdCourseFromName(searchValue);
                            dgvGoal.DataSource = participationRepository.SearchParticipationByCourseId(id);
                            dgvGoal.DataSource = CleanRefresh(dgvGoal);
                            ColumnsSortingDgvParticipations(dgvGoal);
                            dgvGoal.Visible = true;
                        }
                        dgv.Visible = false;
                        valueResult = true;
                        break;
                    }
                }
                if (!valueResult)
                {
                    MessageBox.Show("Impossible de trouver " + searchValue, "Not Found");
                    return;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            btnSearch.Visible = false;
            btnReinit.Visible = true;
            if (isConnected)
            {
                btnDelete.Visible = true;
            }

        }

        /// <summary>
        /// Tri par tranche d'âge de 10 années
        /// </summary>
        /// <param name="indexStartAge"></param>
        /// <param name="courseName"></param>
        /// <param name="dgv"></param>
        internal void RangeSearch(int indexStartAge, string courseName, DataGridView dgv)
        {
            int startRange = (indexStartAge * 10) + 15;

            int idCourse = courseRepository.GetIdCourseFromName(courseName);
            IList<Participation> participations = participationRepository.SearchParticipationByCourseId(idCourse);
            IList<Participation> res = new List<Participation>();

            double age;
            for (int i = 0; i < participations.Count; i++)
            {
                age = participations[i].Participant.NaissanceToAge();

                if ((age >= startRange) && (age < startRange+10))
                {
                    res.Add(participations[i]);
                }
            }

            dgv.DataSource = res;
            dgv.DataSource = CleanRefresh(dgv);
            ColumnsSortingDgvParticipations(dgv);
        }

        /// <summary>
        /// Affichage des informations du dgvCoureurs (liste de tous les coureurs)
        /// </summary>
        /// <param name="dgvCoureurs"></param>
        internal void RefreshContenuCoureurs(DataGridView dgvCoureurs)
        {

            dgvCoureurs.DataSource = null;
            IList<Coureur> coureurs = coureurRepository.GetAll();
            dgvCoureurs.DataSource = coureurs;
            dgvCoureurs.DataSource = CleanRefresh(dgvCoureurs);

        }

        /// <summary>
        /// Affichage des informations du dgvCourses (liste de toutes les courses)
        /// </summary>
        /// <param name="dgvCourses"></param>
        internal void RefreshContenuCourses(DataGridView dgvCourses)
        {
            dgvCourses.DataSource = null;
            IList<Course> courses = courseRepository.GetAll();
            dgvCourses.DataSource = courses;
            dgvCourses.DataSource = CleanRefresh(dgvCourses);
        }

        /// <summary>
        /// Tri des informations affichées par les dgv
        /// </summary>
        /// <param name="dgv"></param>
        /// <returns></returns>
        private DataTable CleanRefresh(DataGridView dgv)
        {
            DataTable dtGoal = new DataTable();
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                if ((column.Name != "IdParticipation") && (column.Name != "IdCoureur") && (column.Name != "IdCourse"))
                {
                    if (column.Name == "DateNaissance") { column.Name = "Age"; }
                    dtGoal.Columns.Add(column.Name);
                }
            }

            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                dtGoal.Rows.Add();
                for (int j = 0; j < dgv.Columns.Count - 1; j++)
                {
                    if (dgv.Rows[i].Cells[j].OwningColumn.Name == "Age") { dtGoal.Rows[i][j] = Math.Round((DateTime.Now - DateTime.Parse(dgv.Rows[i].Cells[j].Value.ToString())).TotalDays / 365.25); }
                    else if (dgv.Rows[i].Cells[j].OwningColumn.Name == "Participant") { dtGoal.Rows[i][j] = dgv.Rows[i].Cells[j+1].Value.ToString(); }
                    else if (dgv.Rows[i].Cells[j].OwningColumn.Name == "IdParticipation") { dtGoal.Rows[i][j] = dgv.Rows[i].Cells[6].Value.ToString(); }
                    else { dtGoal.Rows[i][j] = dgv.Rows[i].Cells[j].Value.ToString(); }
                }
            }
            return dtGoal;
        }

        /// <summary>
        /// Sauvegarde d'un coureur dans la BDD
        /// </summary>
        /// <param name="coureur"></param>
        internal void SaveCoureur(Coureur coureur)
        {
            this.coureurRepository.Save(coureur);
        }

        /// <summary>
        /// Sous-fonction de la fonction d'import des coureurs d'une course (ImportCSVCoureur), lien avec la BDD
        /// </summary>
        /// <param name="course"></param>
        /// <param name="dossards"></param>
        /// <param name="coureurs"></param>
        internal void AddImportCoureursParticipation(Course course, int[] dossards, List<Coureur> coureurs)
        {
            for (int i = 0; i < dossards.Length; i++)
            {
                Participation p = new Participation(course, dossards[i], coureurs[i]);
                this.participationRepository.Save(p);
            }
        }

        /// <summary>
        /// Suppression d'un coureur à partir de la recherche
        /// </summary>
        /// <param name="searchValue"></param>
        internal void DeleteCoureur(string searchValue)
        {
            if(searchValue == "")
            {
                MessageBox.Show("Vous devez chercher un coureur pour le supprimer", "Not Found");
                return;
            }
            else
            {
                DialogResult result2 = MessageBox.Show("Êtes vous sûr de vouloir supprimer ce coureur ?",
                "Important Query",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                if(result2 == DialogResult.Yes)
                {
                    Coureur cour = new Coureur();
                    int idCoureur = coureurRepository.GetIdCoureurFromName(searchValue);
                    IList<Coureur> coureurs = coureurRepository.GetAll();
                    foreach (Coureur c in coureurs)
                    {
                        if (c.IdCoureur == idCoureur)
                        {
                            coureurRepository.RemoveCoureur(c);
                        }
                    }
                }
                else
                {
                    return;
                }

            }
        }

        /// <summary>
        /// Suppression d'une course à partir de la recherche
        /// </summary>
        /// <param name="searchValue"></param>
        internal void DeleteCourse(string searchValue)
        {
            if (searchValue == "")
            {
                MessageBox.Show("Vous devez chercher une course pour la supprimer", "Not Found");
                return;
            }
            else
            {
                DialogResult result2 = MessageBox.Show("Êtes vous sûr de vouloir supprimer cette course ?",
                "Important Query",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                if (result2 == DialogResult.Yes)
                {
                    Course cour = new Course();
                    int idCourse = courseRepository.GetIdCourseFromName(searchValue);
                    IList<Course> courses = courseRepository.GetAll();
                    foreach (Course c in courses)
                    {
                        if (c.IdCourse == idCourse)
                        {
                            courseRepository.RemoveCourse(c);
                        }
                    }
                }
                else
                {
                    return;
                }
            }
        }



        //MISC
        /// <summary>
        /// Tri des informations affichées par le dgv affichant les résultats d'une course
        /// </summary>
        /// <param name="dgv"></param>
        private void ColumnsSortingDgvParticipations(DataGridView dgv)
        {
            dgv.Columns["Participant"].DisplayIndex = 0;
            dgv.Columns["NumDossard"].DisplayIndex = 1;
            dgv.Columns["Course"].DisplayIndex = 2;
            dgv.Columns["Place"].DisplayIndex = 3;
            dgv.Columns["Temps"].DisplayIndex = 4;
            dgv.Columns["VitesseMoyenne"].DisplayIndex = 5;
            dgv.Columns["AllureMoyenne"].DisplayIndex = 6;
        }

        internal IUtilisateurRepository GetUtilisateurRepository() { return utilisateurRepository; }

        /// <summary>
        /// Fonction d'ajout d'une course, lien avec la BDD
        /// </summary>
        /// <param name="nameCourse"></param>
        /// <param name="nbKm"></param>
        /// <param name="typeCourse"></param>
        /// <param name="dgvCourses"></param>
        internal void AddCourse(string nameCourse, int nbKm, string typeCourse, DataGridView dgvCourses)
        {
            Course course = new Course(typeCourse, nameCourse, nbKm);
            this.courseRepository.Save(course);
            RefreshContenuCourses(dgvCourses);
        }
    }
}
