
using _01.Day2Hw3.Business.Concrete;
using _01.Day2Hw3.DataAccess.Concrete.InMemory;
using _01.Day2Hw3.Entities;

CourseManager courseManager = new CourseManager(new InMemoryCourseDal());
courseManager.Add(new Course { Id = 6, CourseName = "JavaScript" });
var courses=courseManager.GetAll();

foreach (var course in courses)
{
    Console.WriteLine(course.CourseName);

}

