using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Domain;

namespace App
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IUtilisateurRepository utilisateurRepository = new UtilisateurRepository();
            ICoureurRepository coureurRepository = new CoureurRepository();
            ICourseRepository courseRepository = new CourseRepository();
            IParticipationRepository participationRepository = new ParticipationRepository();

            Application.Run(new MainForm(utilisateurRepository,  coureurRepository,  courseRepository,  participationRepository));
        }
    }
}
