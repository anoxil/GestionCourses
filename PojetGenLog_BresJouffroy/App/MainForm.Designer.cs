namespace App
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnConnexion = new System.Windows.Forms.Button();
            this.lbConnected = new System.Windows.Forms.Label();
            this.tabCourses = new System.Windows.Forms.TabPage();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.lblTxt2 = new System.Windows.Forms.Label();
            this.lblSearchByAge = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteCourse = new System.Windows.Forms.Button();
            this.cbRangeAge = new System.Windows.Forms.ComboBox();
            this.dgvParticipationsNameCourse = new System.Windows.Forms.DataGridView();
            this.btnCoursesReinit = new System.Windows.Forms.Button();
            this.btnCoureurImport = new System.Windows.Forms.Button();
            this.tbCoursesRecherche = new System.Windows.Forms.TextBox();
            this.btnCoursesRecherche = new System.Windows.Forms.Button();
            this.btnCourseImport = new System.Windows.Forms.Button();
            this.dgvCourses = new System.Windows.Forms.DataGridView();
            this.tabCoureurs = new System.Windows.Forms.TabPage();
            this.lblTxt = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnDeleteCoureur = new System.Windows.Forms.Button();
            this.dgvParticipationsNameCoureurs = new System.Windows.Forms.DataGridView();
            this.btnCoureursReinit = new System.Windows.Forms.Button();
            this.btnCoureursRecherche = new System.Windows.Forms.Button();
            this.tbCoureursRecherche = new System.Windows.Forms.TextBox();
            this.dgvCoureurs = new System.Windows.Forms.DataGridView();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.pbHeader = new System.Windows.Forms.PictureBox();
            this.pbFooter = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbHelp = new System.Windows.Forms.LinkLabel();
            this.tabCourses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipationsNameCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            this.tabCoureurs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipationsNameCoureurs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoureurs)).BeginInit();
            this.tcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFooter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnexion
            // 
            this.btnConnexion.BackColor = System.Drawing.Color.White;
            this.btnConnexion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnexion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConnexion.Location = new System.Drawing.Point(920, 19);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(108, 39);
            this.btnConnexion.TabIndex = 2;
            this.btnConnexion.Text = "Se connecter";
            this.btnConnexion.UseVisualStyleBackColor = false;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // lbConnected
            // 
            this.lbConnected.AutoSize = true;
            this.lbConnected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbConnected.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConnected.ForeColor = System.Drawing.Color.White;
            this.lbConnected.Location = new System.Drawing.Point(917, 33);
            this.lbConnected.Name = "lbConnected";
            this.lbConnected.Size = new System.Drawing.Size(103, 15);
            this.lbConnected.TabIndex = 3;
            this.lbConnected.Text = "Bienvenue admin";
            this.lbConnected.Visible = false;
            // 
            // tabCourses
            // 
            this.tabCourses.Controls.Add(this.btnAddCourse);
            this.tabCourses.Controls.Add(this.lblTxt2);
            this.tabCourses.Controls.Add(this.lblSearchByAge);
            this.tabCourses.Controls.Add(this.label1);
            this.tabCourses.Controls.Add(this.btnDeleteCourse);
            this.tabCourses.Controls.Add(this.cbRangeAge);
            this.tabCourses.Controls.Add(this.dgvParticipationsNameCourse);
            this.tabCourses.Controls.Add(this.btnCoursesReinit);
            this.tabCourses.Controls.Add(this.btnCoureurImport);
            this.tabCourses.Controls.Add(this.tbCoursesRecherche);
            this.tabCourses.Controls.Add(this.btnCoursesRecherche);
            this.tabCourses.Controls.Add(this.btnCourseImport);
            this.tabCourses.Controls.Add(this.dgvCourses);
            this.tabCourses.Location = new System.Drawing.Point(4, 22);
            this.tabCourses.Name = "tabCourses";
            this.tabCourses.Padding = new System.Windows.Forms.Padding(3);
            this.tabCourses.Size = new System.Drawing.Size(1039, 435);
            this.tabCourses.TabIndex = 1;
            this.tabCourses.Text = "Courses";
            this.tabCourses.UseVisualStyleBackColor = true;
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddCourse.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCourse.ForeColor = System.Drawing.Color.White;
            this.btnAddCourse.Location = new System.Drawing.Point(72, 343);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(108, 39);
            this.btnAddCourse.TabIndex = 12;
            this.btnAddCourse.Text = "Ajouter une course";
            this.btnAddCourse.UseVisualStyleBackColor = false;
            this.btnAddCourse.Visible = false;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // lblTxt2
            // 
            this.lblTxt2.AutoSize = true;
            this.lblTxt2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxt2.Location = new System.Drawing.Point(189, 54);
            this.lblTxt2.Name = "lblTxt2";
            this.lblTxt2.Size = new System.Drawing.Size(289, 20);
            this.lblTxt2.TabIndex = 11;
            this.lblTxt2.Text = "Toutes les informations concernant les courses";
            // 
            // lblSearchByAge
            // 
            this.lblSearchByAge.AutoSize = true;
            this.lblSearchByAge.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchByAge.Location = new System.Drawing.Point(736, 276);
            this.lblSearchByAge.Name = "lblSearchByAge";
            this.lblSearchByAge.Size = new System.Drawing.Size(210, 16);
            this.lblSearchByAge.TabIndex = 10;
            this.lblSearchByAge.Text = "Votre recherche par tranche d\'âge :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(718, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Votre recherche par nom :";
            // 
            // btnDeleteCourse
            // 
            this.btnDeleteCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDeleteCourse.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCourse.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCourse.Location = new System.Drawing.Point(882, 144);
            this.btnDeleteCourse.Name = "btnDeleteCourse";
            this.btnDeleteCourse.Size = new System.Drawing.Size(136, 43);
            this.btnDeleteCourse.TabIndex = 8;
            this.btnDeleteCourse.Text = "Supprimer la course";
            this.btnDeleteCourse.UseVisualStyleBackColor = false;
            this.btnDeleteCourse.Visible = false;
            this.btnDeleteCourse.Click += new System.EventHandler(this.btnDeleteCourse_Click);
            // 
            // cbRangeAge
            // 
            this.cbRangeAge.FormattingEnabled = true;
            this.cbRangeAge.Items.AddRange(new object[] {
            "15 - 24",
            "25 - 34",
            "35 - 44",
            "45 - 54",
            "55 - 64",
            "65 - 74"});
            this.cbRangeAge.Location = new System.Drawing.Point(739, 295);
            this.cbRangeAge.Name = "cbRangeAge";
            this.cbRangeAge.Size = new System.Drawing.Size(121, 21);
            this.cbRangeAge.TabIndex = 7;
            this.cbRangeAge.Visible = false;
            this.cbRangeAge.SelectedIndexChanged += new System.EventHandler(this.cbRangeAge_SelectedIndexChanged);
            // 
            // dgvParticipationsNameCourse
            // 
            this.dgvParticipationsNameCourse.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvParticipationsNameCourse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvParticipationsNameCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvParticipationsNameCourse.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvParticipationsNameCourse.Location = new System.Drawing.Point(72, 132);
            this.dgvParticipationsNameCourse.Name = "dgvParticipationsNameCourse";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvParticipationsNameCourse.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvParticipationsNameCourse.Size = new System.Drawing.Size(545, 186);
            this.dgvParticipationsNameCourse.TabIndex = 5;
            this.dgvParticipationsNameCourse.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvParticipationsNameCourse_RowHeaderMouseDoubleClick);
            // 
            // btnCoursesReinit
            // 
            this.btnCoursesReinit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCoursesReinit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoursesReinit.ForeColor = System.Drawing.Color.White;
            this.btnCoursesReinit.Location = new System.Drawing.Point(755, 192);
            this.btnCoursesReinit.Name = "btnCoursesReinit";
            this.btnCoursesReinit.Size = new System.Drawing.Size(101, 25);
            this.btnCoursesReinit.TabIndex = 4;
            this.btnCoursesReinit.Text = "Réinitialiser";
            this.btnCoursesReinit.UseVisualStyleBackColor = false;
            this.btnCoursesReinit.Click += new System.EventHandler(this.btnCoursesReinit_Click);
            // 
            // btnCoureurImport
            // 
            this.btnCoureurImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCoureurImport.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoureurImport.ForeColor = System.Drawing.Color.White;
            this.btnCoureurImport.Location = new System.Drawing.Point(211, 342);
            this.btnCoureurImport.Name = "btnCoureurImport";
            this.btnCoureurImport.Size = new System.Drawing.Size(179, 42);
            this.btnCoureurImport.TabIndex = 1;
            this.btnCoureurImport.Text = "Importer des coureurs";
            this.btnCoureurImport.UseVisualStyleBackColor = false;
            this.btnCoureurImport.Visible = false;
            this.btnCoureurImport.Click += new System.EventHandler(this.btnCoureurImport_Click);
            // 
            // tbCoursesRecherche
            // 
            this.tbCoursesRecherche.Location = new System.Drawing.Point(721, 156);
            this.tbCoursesRecherche.Name = "tbCoursesRecherche";
            this.tbCoursesRecherche.Size = new System.Drawing.Size(155, 20);
            this.tbCoursesRecherche.TabIndex = 3;
            // 
            // btnCoursesRecherche
            // 
            this.btnCoursesRecherche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCoursesRecherche.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoursesRecherche.ForeColor = System.Drawing.Color.White;
            this.btnCoursesRecherche.Location = new System.Drawing.Point(882, 145);
            this.btnCoursesRecherche.Name = "btnCoursesRecherche";
            this.btnCoursesRecherche.Size = new System.Drawing.Size(136, 41);
            this.btnCoursesRecherche.TabIndex = 2;
            this.btnCoursesRecherche.Text = "Rechercher";
            this.btnCoursesRecherche.UseVisualStyleBackColor = false;
            this.btnCoursesRecherche.Click += new System.EventHandler(this.btnCoursesRecherche_Click);
            // 
            // btnCourseImport
            // 
            this.btnCourseImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCourseImport.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourseImport.ForeColor = System.Drawing.Color.White;
            this.btnCourseImport.Location = new System.Drawing.Point(438, 345);
            this.btnCourseImport.Name = "btnCourseImport";
            this.btnCourseImport.Size = new System.Drawing.Size(179, 37);
            this.btnCourseImport.TabIndex = 1;
            this.btnCourseImport.Text = "Importer des résultats";
            this.btnCourseImport.UseVisualStyleBackColor = false;
            this.btnCourseImport.Visible = false;
            this.btnCourseImport.Click += new System.EventHandler(this.btnCourseImport_Click);
            // 
            // dgvCourses
            // 
            this.dgvCourses.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCourses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCourses.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCourses.Location = new System.Drawing.Point(193, 132);
            this.dgvCourses.Name = "dgvCourses";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCourses.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCourses.Size = new System.Drawing.Size(340, 154);
            this.dgvCourses.TabIndex = 0;
            this.dgvCourses.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCourses_RowHeaderMouseDoubleClick);
            // 
            // tabCoureurs
            // 
            this.tabCoureurs.Controls.Add(this.lblTxt);
            this.tabCoureurs.Controls.Add(this.lblSearch);
            this.tabCoureurs.Controls.Add(this.btnDeleteCoureur);
            this.tabCoureurs.Controls.Add(this.dgvParticipationsNameCoureurs);
            this.tabCoureurs.Controls.Add(this.btnCoureursReinit);
            this.tabCoureurs.Controls.Add(this.btnCoureursRecherche);
            this.tabCoureurs.Controls.Add(this.tbCoureursRecherche);
            this.tabCoureurs.Controls.Add(this.dgvCoureurs);
            this.tabCoureurs.Location = new System.Drawing.Point(4, 22);
            this.tabCoureurs.Name = "tabCoureurs";
            this.tabCoureurs.Padding = new System.Windows.Forms.Padding(3);
            this.tabCoureurs.Size = new System.Drawing.Size(1039, 435);
            this.tabCoureurs.TabIndex = 0;
            this.tabCoureurs.Text = "Coureurs";
            this.tabCoureurs.UseVisualStyleBackColor = true;
            // 
            // lblTxt
            // 
            this.lblTxt.AutoSize = true;
            this.lblTxt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxt.Location = new System.Drawing.Point(81, 26);
            this.lblTxt.Name = "lblTxt";
            this.lblTxt.Size = new System.Drawing.Size(486, 18);
            this.lblTxt.TabIndex = 8;
            this.lblTxt.Text = "Toutes les informations concernant les coureurs et leurs participations";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(691, 149);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(154, 16);
            this.lblSearch.TabIndex = 7;
            this.lblSearch.Text = "Votre recherche par nom:";
            // 
            // btnDeleteCoureur
            // 
            this.btnDeleteCoureur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDeleteCoureur.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCoureur.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCoureur.Location = new System.Drawing.Point(911, 154);
            this.btnDeleteCoureur.Name = "btnDeleteCoureur";
            this.btnDeleteCoureur.Size = new System.Drawing.Size(95, 50);
            this.btnDeleteCoureur.TabIndex = 6;
            this.btnDeleteCoureur.Text = "Supprimer le coureur";
            this.btnDeleteCoureur.UseVisualStyleBackColor = false;
            this.btnDeleteCoureur.Visible = false;
            this.btnDeleteCoureur.Click += new System.EventHandler(this.btnDeleteCoureur_Click);
            // 
            // dgvParticipationsNameCoureurs
            // 
            this.dgvParticipationsNameCoureurs.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvParticipationsNameCoureurs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvParticipationsNameCoureurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvParticipationsNameCoureurs.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvParticipationsNameCoureurs.GridColor = System.Drawing.Color.DarkGray;
            this.dgvParticipationsNameCoureurs.Location = new System.Drawing.Point(29, 71);
            this.dgvParticipationsNameCoureurs.Name = "dgvParticipationsNameCoureurs";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvParticipationsNameCoureurs.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvParticipationsNameCoureurs.Size = new System.Drawing.Size(642, 222);
            this.dgvParticipationsNameCoureurs.TabIndex = 5;
            this.dgvParticipationsNameCoureurs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParticipationsNameCoureurs_CellContentClick);
            this.dgvParticipationsNameCoureurs.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvParticipationsNameCoureurs_RowHeaderMouseDoubleClick);
            // 
            // btnCoureursReinit
            // 
            this.btnCoureursReinit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCoureursReinit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoureursReinit.ForeColor = System.Drawing.Color.White;
            this.btnCoureursReinit.Location = new System.Drawing.Point(741, 209);
            this.btnCoureursReinit.Name = "btnCoureursReinit";
            this.btnCoureursReinit.Size = new System.Drawing.Size(95, 36);
            this.btnCoureursReinit.TabIndex = 4;
            this.btnCoureursReinit.Text = "Réinitialiser";
            this.btnCoureursReinit.UseMnemonic = false;
            this.btnCoureursReinit.UseVisualStyleBackColor = false;
            this.btnCoureursReinit.Click += new System.EventHandler(this.btnCoureursReinit_Click);
            // 
            // btnCoureursRecherche
            // 
            this.btnCoureursRecherche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCoureursRecherche.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoureursRecherche.ForeColor = System.Drawing.Color.White;
            this.btnCoureursRecherche.Location = new System.Drawing.Point(911, 154);
            this.btnCoureursRecherche.Name = "btnCoureursRecherche";
            this.btnCoureursRecherche.Size = new System.Drawing.Size(95, 50);
            this.btnCoureursRecherche.TabIndex = 3;
            this.btnCoureursRecherche.Text = "Rechercher";
            this.btnCoureursRecherche.UseVisualStyleBackColor = false;
            this.btnCoureursRecherche.Click += new System.EventHandler(this.btnCoureursRecherche_Click);
            // 
            // tbCoureursRecherche
            // 
            this.tbCoureursRecherche.Location = new System.Drawing.Point(694, 170);
            this.tbCoureursRecherche.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbCoureursRecherche.MinimumSize = new System.Drawing.Size(30, 30);
            this.tbCoureursRecherche.Name = "tbCoureursRecherche";
            this.tbCoureursRecherche.Size = new System.Drawing.Size(193, 20);
            this.tbCoureursRecherche.TabIndex = 2;
            // 
            // dgvCoureurs
            // 
            this.dgvCoureurs.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCoureurs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvCoureurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCoureurs.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvCoureurs.Location = new System.Drawing.Point(29, 110);
            this.dgvCoureurs.Name = "dgvCoureurs";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCoureurs.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvCoureurs.Size = new System.Drawing.Size(631, 222);
            this.dgvCoureurs.TabIndex = 0;
            this.dgvCoureurs.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCoureurs_RowHeaderMouseDoubleClick);
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tabCoureurs);
            this.tcMain.Controls.Add(this.tabCourses);
            this.tcMain.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tcMain.Location = new System.Drawing.Point(34, 103);
            this.tcMain.Multiline = true;
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(1047, 461);
            this.tcMain.TabIndex = 1;
            this.tcMain.TabStop = false;
            // 
            // pbHeader
            // 
            this.pbHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pbHeader.Location = new System.Drawing.Point(2, 1);
            this.pbHeader.Name = "pbHeader";
            this.pbHeader.Size = new System.Drawing.Size(1111, 85);
            this.pbHeader.TabIndex = 4;
            this.pbHeader.TabStop = false;
            // 
            // pbFooter
            // 
            this.pbFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pbFooter.Location = new System.Drawing.Point(2, 591);
            this.pbFooter.Name = "pbFooter";
            this.pbFooter.Size = new System.Drawing.Size(1111, 36);
            this.pbFooter.TabIndex = 5;
            this.pbFooter.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkLabel1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(1049, 19);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(32, 32);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "X";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(67, -18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 104);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lbHelp
            // 
            this.lbHelp.AutoSize = true;
            this.lbHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbHelp.LinkColor = System.Drawing.Color.White;
            this.lbHelp.Location = new System.Drawing.Point(508, 602);
            this.lbHelp.Name = "lbHelp";
            this.lbHelp.Size = new System.Drawing.Size(100, 13);
            this.lbHelp.TabIndex = 8;
            this.lbHelp.TabStop = true;
            this.lbHelp.Text = "Aide à la navigation";
            this.lbHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbHelp_LinkClicked);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnCoursesRecherche;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1115, 627);
            this.Controls.Add(this.lbHelp);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pbFooter);
            this.Controls.Add(this.lbConnected);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.pbHeader);
            this.Name = "MainForm";
            this.Text = "GestionCourse";
            this.tabCourses.ResumeLayout(false);
            this.tabCourses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipationsNameCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            this.tabCoureurs.ResumeLayout(false);
            this.tabCoureurs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipationsNameCoureurs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoureurs)).EndInit();
            this.tcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFooter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.Label lbConnected;
        private System.Windows.Forms.TabPage tabCourses;
        private System.Windows.Forms.DataGridView dgvParticipationsNameCourse;
        private System.Windows.Forms.Button btnCoursesReinit;
        private System.Windows.Forms.TextBox tbCoursesRecherche;
        private System.Windows.Forms.Button btnCoursesRecherche;
        private System.Windows.Forms.Button btnCourseImport;
        private System.Windows.Forms.DataGridView dgvCourses;
        private System.Windows.Forms.TabPage tabCoureurs;
        private System.Windows.Forms.DataGridView dgvParticipationsNameCoureurs;
        private System.Windows.Forms.Button btnCoureursReinit;
        private System.Windows.Forms.Button btnCoureursRecherche;
        private System.Windows.Forms.TextBox tbCoureursRecherche;
        private System.Windows.Forms.Button btnCoureurImport;
        private System.Windows.Forms.DataGridView dgvCoureurs;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.ComboBox cbRangeAge;
        private System.Windows.Forms.Button btnDeleteCoureur;
        private System.Windows.Forms.Button btnDeleteCourse;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.PictureBox pbHeader;
        private System.Windows.Forms.PictureBox pbFooter;
        private System.Windows.Forms.Label lblSearchByAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTxt2;
        private System.Windows.Forms.Label lblTxt;
        private System.Windows.Forms.LinkLabel lbHelp;
        private System.Windows.Forms.Button btnAddCourse;
    }
}

