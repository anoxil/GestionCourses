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
    public class testsCoureur
    {
        ICoureurRepository coureurRepository = new CoureurRepository();

        [TestMethod]
        public void GetAllCoureursTest()
        {
            IList<Coureur> coureurs = coureurRepository.GetAll();
            int nbCoureursBdd = coureurs.Count;
            int nbCoureursGetAll = 7;
            Assert.AreEqual(nbCoureursBdd, nbCoureursGetAll);
        }

        [TestMethod]
        public void SaveCoureurTest()
        {
            DateTime naissance = new DateTime();
            Coureur cour1 = new Coureur("Jouffroy","Emma",  "F",  "courriel",  "FFA",  naissance);
            coureurRepository.Save(cour1);
            IList<Coureur> coureurs = coureurRepository.GetAll();
            Coureur lastSaveCoureur = coureurs[coureurs.Count - 1];
            string nameSaved = lastSaveCoureur.Nom;
            Assert.AreEqual("Jouffroy", nameSaved);
        }

        [TestMethod]

        public void GetIdCoureurFromNameTest()
        {
            int idTestBdd = coureurRepository.GetIdCoureurFromName("Bres");
            int idAttended = 1;
            Assert.AreEqual(idAttended, idTestBdd);
        }

        [TestMethod]
        public void RemoveCoureurTest()
        {
            IList<Coureur> coureursBeforeRemove = coureurRepository.GetAll();
            int idBeforeRemove = coureursBeforeRemove[coureursBeforeRemove.Count - 1].IdCoureur;
            coureurRepository.RemoveCoureur(coureursBeforeRemove[coureursBeforeRemove.Count - 1]);
            IList<Coureur> coureursAfterRemove = coureurRepository.GetAll();
            int idAfterRemove = coureursAfterRemove[coureursAfterRemove.Count - 1].IdCoureur;
            Assert.AreNotEqual(idBeforeRemove, idAfterRemove);
        }

    }
}
