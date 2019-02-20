using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public interface IParticipationRepository
    {
        void Save(Participation participation);
        void Remove(Participation participation);
        IList<Participation> GetAll();
        IList<Participation> SearchParticipationByCoureurId(int idCoureur);
        IList<Participation> SearchParticipationByCourseId(int idCourse);
        void UpdateParticipationIncomplete(int idCourse, int idCoureur, double vitesseMoyenne, string allureMoyenne, string temps, int place);
    }
}