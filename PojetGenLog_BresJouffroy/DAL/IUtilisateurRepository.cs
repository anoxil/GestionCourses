using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;


namespace DAL
{
    public interface IUtilisateurRepository
    {
        void Remove(Utilisateur utilisateur);
        IList<Utilisateur> GetAll();
        string GetEmail(string Email);
        string GetMdpByMail(string Email);
    }
}
