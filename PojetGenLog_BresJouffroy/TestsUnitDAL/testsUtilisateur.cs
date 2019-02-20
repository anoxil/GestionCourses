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
    public class testsUtilisateur
    {
        IUtilisateurRepository utilisateurRepository = new UtilisateurRepository();

        public void GetAllUtilisateursTest()
        {
            IList<Utilisateur> utilisateurs = utilisateurRepository.GetAll();
            int nbUtilisateurBdd = utilisateurs.Count;
            int nbUtilisateursGetAll = 3;
            Assert.AreEqual(nbUtilisateurBdd, nbUtilisateursGetAll);
        }

        [TestMethod]
        public void GetEmailTest()
        {
            string emailBdd = utilisateurRepository.GetEmail("ejouffroy@ensc.fr");
            string emailAttended = "ejouffroy@ensc.fr";
            Assert.AreEqual(emailBdd, emailAttended);
        }

        [TestMethod]
        public void GetMdpByMailTest()
        {
            string mdpBdd = utilisateurRepository.GetMdpByMail("ejouffroy@ensc.fr");
            string mdpAttended = "ejouffroy";
            Assert.AreEqual(mdpBdd, mdpAttended);
        }

        [TestMethod]
        public void RemoveUtilisateurTest()
        {
            IList<Utilisateur> utilisateursBeforeRemove = utilisateurRepository.GetAll();
            int idBeforeRemove = utilisateursBeforeRemove[utilisateursBeforeRemove.Count - 1].IdUtilisateur;
            utilisateurRepository.Remove(utilisateursBeforeRemove[utilisateursBeforeRemove.Count - 1]);
            IList<Utilisateur> utilisateursAfterRemove = utilisateurRepository.GetAll();
            int idAfterRemove = utilisateursAfterRemove[utilisateursAfterRemove.Count - 1].IdUtilisateur;
            Assert.AreNotEqual(idBeforeRemove, idAfterRemove);
        }
    }
}
