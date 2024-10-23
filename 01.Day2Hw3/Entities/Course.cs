using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Day2Hw3.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }


        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; }


    }
}
