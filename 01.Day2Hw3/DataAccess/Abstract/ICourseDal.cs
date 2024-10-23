using _01.Day2Hw3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Day2Hw3.DataAccess.Abstract
{
    public interface ICourseDal
    {
        List<Course> GetAll();
        void Add(Course course);
        void Update(Course course);
        void Delete(Course course);


    }
}
