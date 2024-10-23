using _01.Day2Hw3.DataAccess.Abstract;
using _01.Day2Hw3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Day2Hw3.DataAccess.Concrete.InMemory
{
    public class InMemoryInstructorDal : IInstructorDal
    {
        List<Instructor> _instructors;
        public InMemoryInstructorDal()
        {
            _instructors = new List<Instructor>
            {
                new Instructor{Id=1, FirstName="Engin", LastName="Demiroğ"},
                new Instructor{Id=2, FirstName="Kerem", LastName="Varış"},
                new Instructor{Id=3, FirstName="Berkay", LastName="Bilgin"},
                new Instructor{Id=4, FirstName="Murat", LastName="Kurtboğan"},
                new Instructor{Id=5, FirstName="Halil", LastName="İbrahim Kalaycı"},
            };
        }

        public void Add(Instructor instructor)
        {
            _instructors.Add(instructor);
        }

        public void Delete(Instructor instructor)
        {
            _instructors.Remove(instructor);
        }

        public List<Instructor> GetAll()
        {
            return _instructors;
        }

        public void Update(Instructor instructor)
        {
            var instructorToUpdate = _instructors.FirstOrDefault(i => i.Id == instructor.Id);
            if (instructorToUpdate==null)
            {
                Console.WriteLine("eğitmen bulunamadı");
            }

            instructorToUpdate.FirstName = instructor.FirstName;
            instructorToUpdate.LastName = instructor.LastName;


            
        }
    }
}
