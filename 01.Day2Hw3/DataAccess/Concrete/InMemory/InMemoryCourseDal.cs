using _01.Day2Hw3.DataAccess.Abstract;
using _01.Day2Hw3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Day2Hw3.DataAccess.Concrete.InMemory
{
    public class InMemoryCourseDal : ICourseDal
    {
        List<Course> _courses;

        public InMemoryCourseDal()
        {
            _courses = new List<Course>
            {
                new Course { Id = 1, CourseName = "C# Programming", InstructorId = 1, CategoryId = 1 },
                new Course { Id = 2, CourseName = "Java Programming", InstructorId = 2, CategoryId = 1 },
                new Course { Id = 3, CourseName = "Python Programming", InstructorId = 3, CategoryId = 1 },
                new Course { Id = 4, CourseName = "C++ Programming", InstructorId = 4, CategoryId = 1 },
                new Course { Id = 5, CourseName = "C Programming", InstructorId = 5, CategoryId = 1 }
            };
        }
        public void Add(Course course)
        {
            _courses.Add(course);
        }

        public void Delete(Course course)
        {
            _courses.Remove(course);
        }

        public List<Course> GetAll()
        {
            return _courses;
        }

        public void Update(Course course)
        {
            _courses[_courses.FindIndex(c => c.Id == course.Id)] = course;
        }
    }
}
