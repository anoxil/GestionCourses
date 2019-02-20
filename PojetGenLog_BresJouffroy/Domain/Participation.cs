using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
   public class Participation
    {
        public virtual int IdParticipation { get; set; }
        public virtual int NumDossard { get; set; }
        public virtual Coureur Participant { get; set; }
        public virtual Course Course { get; set; }
        public virtual string Temps { get; set; }
        public virtual int Place { get; set; }
        public virtual double VitesseMoyenne { get; set; }
        public virtual string AllureMoyenne { get; set; }

        public Participation()
        {
            NumDossard = 0;
            Participant = new Coureur();
            Course = new Course();
            Temps = "00:00:00";
            Place = 0;
            VitesseMoyenne = 0D;
            AllureMoyenne = "0'0\"";
        }

        public Participation(int numDossard, Coureur coureur, Course course, string temps, int place, double vitmoy, string allmoy)
        {
            NumDossard = numDossard;
            Participant = coureur;
            Course = course;
            Temps = temps;
            Place = place;
            VitesseMoyenne = vitmoy;
            AllureMoyenne = allmoy;
        }

        public Participation(Course course, int dossard, Coureur coureur)
        {
            NumDossard = dossard;
            Participant = coureur;
            Course = course;
            Temps = "00:00:00";
            Place = 0;
            VitesseMoyenne = 0D;
            AllureMoyenne = "0'0\"";
        }

        public override string ToString()
        {
            return Participant.ToString() + " : " + Temps;
        }
    }
}
