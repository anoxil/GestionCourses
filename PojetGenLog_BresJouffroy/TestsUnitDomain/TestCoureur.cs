using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL;
using Domain;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsUnitDomain
{
    [TestClass]
    public class TestCoureur
    {
        [TestMethod]
        public void NaissanceToAgeTest()
        {
            DateTime naissance = new DateTime(1997, 05, 24, 0, 0, 0);
            Coureur cour1 = new Coureur("Jouffroy", "Emma", "F", "courriel", "FFA", naissance);
            double ageDb = cour1.NaissanceToAge();
            double ageAttended = 21;
            Assert.AreEqual(ageAttended, ageDb);
        }
    }
}
