using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;


namespace DAL
{
    public class CourseRepository : Repository, ICourseRepository
    {
        public IList<Course> GetAll()
        {
            return Session.Query<Course>().ToList();
        }
        public void Save(Course course)
        {
            Session.SaveOrUpdate(course);
        }
        public int GetIdCourseFromName(string name)
        {
            var myQuery = Session.CreateQuery(@" 
            select IdCourse from Course as c where 
            c.Nom = :Name");
            myQuery.SetParameter("Name", name);
            int id = Convert.ToInt32(myQuery.UniqueResult());
            return id;
        }

        public Course GetCourseInstanceFromName(string name)
        {
            Course course = new Course();
            int idCourse = this.GetIdCourseFromName(name);
            IList<Course> courses = this.GetAll();
            foreach (Course c in courses)
            {
                if (c.IdCourse == idCourse)
                {
                    course = c;
                }
            }
            return course;
        }

        public void RemoveCourse(Course course)
        {
            IParticipationRepository participationRepository = new ParticipationRepository();
            IList<Participation> participations = participationRepository.SearchParticipationByCourseId(course.IdCourse);
            foreach(Participation p in participations)
            {
                Session.Delete(p);
                Session.Flush();
            }
            Session.Delete(course);
            Session.Flush();
        }
    }
}
