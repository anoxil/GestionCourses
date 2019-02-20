using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Coureur
    {
        public virtual int IdCoureur { get; set; }
        public virtual string Nom { get; set; }
        public virtual string Prenom { get; set; }
        public virtual string Sexe { get; set; }
        public virtual string Courriel { get; set; }
        public virtual string LicenceFFA { get; set; }
        public virtual DateTime DateNaissance { get; set; }

        public Coureur()
        {
            Nom = "";
            Prenom = "";
            Sexe = "";
            Courriel = "";
            LicenceFFA = "";
            DateNaissance = new DateTime();
        }

        public Coureur(string nom, string prenom, string sexe, string courriel, string licence, DateTime naissance)
        {
            Nom = nom;
            Prenom = prenom;
            Sexe = sexe;
            Courriel = courriel;
            LicenceFFA = licence;
            DateNaissance = naissance;
        }

        public override string ToString()
        {
            return Nom + " " + Prenom;
        }

        public virtual double NaissanceToAge()
        {
            return Math.Floor((DateTime.Now - DateTime.Parse(DateNaissance.ToString())).TotalDays / 365.25);
        }
    }
}
