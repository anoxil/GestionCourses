using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL;
using Domain;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TestsUnitDAL
{
    [TestClass]
    public class testsParticipation
    {
        ICourseRepository courseRepository = new CourseRepository();
        IParticipationRepository participationRepository = new ParticipationRepository();
        ICoureurRepository coureurRepository = new CoureurRepository();


        [TestMethod]
        public void GetAllParticipationsTest()
        {
            IList<Participation> participations = participationRepository.GetAll();
            int nbParticipationsBdd = 4;
            int nbParticipationsGetAll = participations.Count; ;
            Assert.AreEqual(nbParticipationsBdd, nbParticipationsGetAll);
        }

        [TestMethod] 
        public void SaveParticipationTest()
        {

            IList<Coureur> coureurs = coureurRepository.GetAll();
            IList<Course> courses = courseRepository.GetAll();
            Coureur coureurPartTest = coureurs[1];
            Course coursePartTest = courses[1];
            Participation part1 = new Participation( 1, coureurPartTest, coursePartTest,  "12",  3,  0.5,  "allmoy");
            participationRepository.Save(part1);
            IList<Participation> participations = participationRepository.GetAll();
            Participation lastSaveParticipation = participations[participations.Count - 1];
            int placeSaved = lastSaveParticipation.NumDossard;
            Assert.AreEqual(1, placeSaved);
        }

        [TestMethod]
        public void SearchParticipationByCoureurIdTest()
        {

            IList<Coureur> coureurs = coureurRepository.GetAll();
            int courIdTest = coureurs[2].IdCoureur;
            IList<Participation> participations = participationRepository.SearchParticipationByCoureurId(courIdTest);
            int cpt = 0; 
            foreach(Participation p in participations)
            {
                cpt++;
            }
            Assert.AreEqual(1, cpt);
        }

        [TestMethod]
        public void SearchParticipationByCourseIdTest()
        {

            IList<Course> courses = courseRepository.GetAll();
            int courseIdTest = courses[0].IdCourse;
            IList<Participation> participations = participationRepository.SearchParticipationByCourseId(courseIdTest);
            int cpt = 0;
            foreach (Participation p in participations)
            {
                cpt++;
            }
            Assert.AreEqual(3, cpt);
        }

        [TestMethod]

        public void RemoveParticipationTest()
        {
            IList<Participation> participationsBeforeRemove = participationRepository.GetAll();
            int idBeforeRemove = participationsBeforeRemove[participationsBeforeRemove.Count - 1].IdParticipation;
            participationRepository.Remove(participationsBeforeRemove[participationsBeforeRemove.Count - 1]);
            IList<Participation> participationsAfterRemove = participationRepository.GetAll();
            int idAfterRemove = participationsAfterRemove[participationsAfterRemove.Count - 1].IdParticipation;
            Assert.AreNotEqual(idBeforeRemove, idAfterRemove);
        }
    }
}
