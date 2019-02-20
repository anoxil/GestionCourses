using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Course
    {
        public virtual int IdCourse { get; set; }
        public virtual string TypeCourse { get; set; }
        public virtual string Nom { get; set; }
        public virtual int NbKm { get; set; }


        public Course()
        {
            TypeCourse = "";
            Nom = "";
            NbKm = 0;
        }

        public Course(string typeCourse, string nom, int nbkm)
        {
            TypeCourse = typeCourse;
            Nom = nom;
            NbKm = nbkm;
        }

        public override string ToString()
        {
            return Nom;
        }
    }
}
