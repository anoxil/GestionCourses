using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    /// <summary>
    /// Interface d'accès aux utilisateurs de la bibliothèque
    /// </summary>
    public interface ICoureurRepository
    {
        /// <summary>
        /// Récupère la liste des utilisateurs
        /// </summary>
        /// <returns></returns>
        IList<Coureur> GetAll();
        int GetIdCoureurFromName(string name);
        void Save(Coureur coureur);
        Coureur GetCoureurInstanceFromId(int id);
        int GetIdCoureurFromNameAndFirstName(string fullname);
        void RemoveCoureur(Coureur coureur);
    }
}