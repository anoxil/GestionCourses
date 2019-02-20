using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using NHibernate.Linq;

namespace DAL
{
    public class ParticipationRepository : Repository, IParticipationRepository
    {
        public void Save(Participation participation)
        {
            Session.SaveOrUpdate(participation);
            Session.Flush();
        }

        public void Remove(Participation participation)
        {
            Session.Delete(participation);
            Session.Flush();
        }

        public IList<Participation> GetAll()
        {
            return Session.Query<Participation>().ToList();
        }

        public IList<Participation> SearchParticipationByCoureurId(int idCoureur)
        {
            return Session.Query<Participation>().Where(p => p.Participant.IdCoureur == idCoureur).ToList();
        }

        public IList<Participation> SearchParticipationByCourseId(int idCourse)
        {
            return Session.Query<Participation>().Where(p => p.Course.IdCourse == idCourse).ToList();
        }


        public void UpdateParticipationIncomplete(int idCourse, int idCoureur, double vitesseMoyenne, string allureMoyenne, string temps, int place)
        {
            Session.Query<Participation>()
            .Where(p => (p.Participant.IdCoureur == idCoureur) && (p.Course.IdCourse == idCourse))
            .Update(p => new Participation { Temps = temps, Place = place, VitesseMoyenne = vitesseMoyenne, AllureMoyenne = allureMoyenne });
            Session.Flush();
        }
    }
}