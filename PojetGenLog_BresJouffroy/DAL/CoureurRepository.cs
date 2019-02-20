using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class CoureurRepository : Repository, ICoureurRepository
    {
        public IList<Coureur> GetAll()
        {
            return Session.Query<Coureur>().ToList();
        }

        public void Save(Coureur coureur)
        {
            Session.SaveOrUpdate(coureur);
            Session.Flush();
        }



        public int GetIdCoureurFromName(string name)
        {
            var myQuery = Session.CreateQuery(@" 
            select IdCoureur from Coureur as c where 
            c.Nom = :Nom");
            myQuery.SetParameter("Nom", name);
            int id = Convert.ToInt32(myQuery.UniqueResult());
            return id;
        }

        public int GetIdCoureurFromNameAndFirstName(string fullname)
        {
            string[] names = fullname.Split(' ');
            string lastName = names[0];
            string firstName = names[1];

            var myQuery = Session.CreateQuery(@" 
            select IdCoureur from Coureur as c where 
            c.Nom = :Nom and c.Prenom = :Prenom");
            myQuery.SetParameter("Nom", lastName);
            myQuery.SetParameter("Prenom", firstName);
            int id = Convert.ToInt32(myQuery.UniqueResult());
            return id;
        }

        public Coureur GetCoureurInstanceFromId(int id)
        {
            Coureur coureur = new Coureur();
            IList<Coureur> coureurs = this.GetAll();
            foreach (Coureur c in coureurs)
            {
                if (c.IdCoureur == id)
                {
                    coureur = c;
                }
            }
            return coureur;
        }

        public void RemoveCoureur(Coureur coureur)
        {
            IParticipationRepository participationRepository = new ParticipationRepository();
            IList<Participation> participations = participationRepository.SearchParticipationByCoureurId(coureur.IdCoureur);
            foreach (Participation p in participations)
            {
                Session.Delete(p);
                Session.Flush();
            }
            Session.Delete(coureur);
            Session.Flush();
        }
    }
}

 