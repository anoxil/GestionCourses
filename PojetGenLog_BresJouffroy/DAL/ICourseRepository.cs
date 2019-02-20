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
    public interface ICourseRepository
    {
        /// <summary>
        /// Récupère la liste des utilisateurs
        /// </summary>
        /// <returns></returns>
        IList<Course> GetAll();
        int GetIdCourseFromName(string name);
        void Save(Course course);
        Course GetCourseInstanceFromName(string name);
        void RemoveCourse(Course course);
    }
}