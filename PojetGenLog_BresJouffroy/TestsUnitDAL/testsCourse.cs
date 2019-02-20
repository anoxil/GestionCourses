using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL;
using Domain;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsUnitDAL
{
    [TestClass]
    public class testsCourse
    {
        ICourseRepository courseRepository = new CourseRepository();

        [TestMethod]
        public void GetAllCoursesTests()
        {
            IList<Course> courses = courseRepository.GetAll();
            int nbCoursesBdd = 2;
            int nbCoursesGetAll = courses.Count; ;
            Assert.AreEqual(nbCoursesGetAll, nbCoursesBdd);
        }

        [TestMethod]
        public void SaveCourseTests()
        {
            Course cour1 = new Course( "Marathon",  "Marathon de Paris",  50);
            courseRepository.Save(cour1);
            IList<Course> courses = courseRepository.GetAll();
            Course lastSaveCourse = courses[courses.Count - 1];
            string nameSaved = lastSaveCourse.TypeCourse;
            Assert.AreEqual("Marathon", nameSaved);
        }

        [TestMethod]

        public void GetIdCourseFromNameTest()
        {
            int idTestBdd = courseRepository.GetIdCourseFromName("Course de Bordeaux");
            int idAttended = 2;
            Assert.AreEqual(idAttended, idTestBdd);
        }

        [TestMethod]
        public void RemoveCourseTest()
        {
            IList<Course> coursesBeforeRemove = courseRepository.GetAll();
            int idBeforeRemove = coursesBeforeRemove[coursesBeforeRemove.Count - 1].IdCourse;
            courseRepository.RemoveCourse(coursesBeforeRemove[coursesBeforeRemove.Count - 1]);
            IList<Course> coursesAfterRemove = courseRepository.GetAll();
            int idAfterRemove = coursesAfterRemove[coursesAfterRemove.Count - 1].IdCourse;
            Assert.AreNotEqual(idBeforeRemove, idAfterRemove);
        }
    }
}
