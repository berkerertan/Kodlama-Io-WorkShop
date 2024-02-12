using Kodlama_Io_WorkShop.DataAccess.Abstracts;
using Kodlama_Io_WorkShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama_Io_WorkShop.DataAccess.Concretes.InMemory
{
    public class ImCourseDal : ICourseDal
    {
        List<Course> courses = new List<Course>();
        public ImCourseDal()
        {
            courses.Add(new Course {CourseId=1,CourseName="2024 Yazılım Geliştirici ...",Complete=0,Description="Harika kurs",Price=0 });
            courses.Add(new Course { CourseId = 2, CourseName = "Python Kursu", Complete = 10, Description = "Harika kurs2", Price = 0 });
            courses.Add(new Course { CourseId = 3, CourseName = "Java Kursu", Complete = 0, Description = "Harika kurs3", Price = 0 });
            courses.Add(new Course { CourseId = 4, CourseName = "Angular Kursu", Complete = 20, Description = "Harika kurs4", Price = 0 });

        }
        public void Add(Course course)
        {
            courses.Add(course);
        }

        public void Delete(Course course)
        {
            courses.Remove(course);
        }

        public List<Course> GetAll()
        {
            return courses;
        }

        public void Update(Course course)
        {
            throw new NotImplementedException();
        }
    }
}
