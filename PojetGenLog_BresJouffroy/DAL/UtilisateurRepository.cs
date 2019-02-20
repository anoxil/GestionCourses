using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;


namespace DAL
{
    public class UtilisateurRepository : Repository, IUtilisateurRepository
    {
        public IList<Utilisateur> GetAll()
        {
            return Session.Query<Utilisateur>().ToList();
        }
        public void Remove(Utilisateur utilisateur)
        {
            Session.Delete(utilisateur);
            Session.Flush();
        }
        public string GetEmail(string Email)
        {
            var myQuery = Session.CreateQuery(@" 
            select Email from Utilisateur as e where 
            e.Email = :Email");
            myQuery.SetParameter("Email", Email);
            string email = Convert.ToString(myQuery.UniqueResult());
            return email;
        }
        public string GetMdpByMail(string Email)
        {
            var myQuery = Session.CreateQuery(@" 
            select MotDePasse from Utilisateur as e where 
            e.Email = :Email");
            myQuery.SetParameter("Email", Email);
            string mdp = Convert.ToString(myQuery.UniqueResult());
            return mdp;
        }
    }
}
