using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Domain;

namespace TestsDAL
{
    class Program
    {
        static void Main(string[] args)
        {


            ICoureurRepository coureurRepo = new CoureurRepository();

            /* Vérifie si il récupère bien le bon ID à partir du nom d'un coureur, ici le 1er*/

            Console.Write("Récupération de l'ID de Raphael Bres : ");
            int id = coureurRepo.GetIdCoureurFromName("Bres");
            Console.WriteLine("ID coureur : " + id);


            /* Vérifie si il récupère bien le bon ID à partir du nom d'une course, ici la 1ere*/

            ICourseRepository courseRepo = new CourseRepository();


            Console.Write("Récupération de l'ID de Marathon : ");
            int idCourse = courseRepo.GetIdCourseFromName("Marathon ");
            Console.WriteLine("ID course : " + idCourse);
            Console.ReadKey();

            /* Vérifie si il récupère bien l'ensemble des participations*/


            IParticipationRepository partictipationRepo = new ParticipationRepository();

            Console.Write("Récupération des participations en fonction de l'ID d'une course : ");
            IList<Participation> participationsCourse = new List<Participation>();
            participationsCourse = partictipationRepo.SearchParticipationByCourseId(2);

            foreach (Participation participation in participationsCourse)
            {
                Console.WriteLine(participation.Participant);
            }


            Console.Write("Récupération des participations en fonction de l'ID d'un coureur : ");
            IList<Participation> participationsCoureur = new List<Participation>();
            participationsCoureur = partictipationRepo.SearchParticipationByCoureurId(2);

            foreach (Participation participation in participationsCoureur)
            {
                Console.WriteLine(participation.Participant);
            }
            Console.ReadKey();
        }
    }

}
