﻿using _01.Day2Hw3.Business.Abstract;
using _01.Day2Hw3.DataAccess.Abstract;
using _01.Day2Hw3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Day2Hw3.Business.Concrete
{
    public class CourseManager: ICourseService
    {
        private readonly ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public void Add(Course course)
        {
            _courseDal.Add(course);
        }

        public void Delete(Course course)
        {
                 _courseDal.Delete(course);
        }

        public List<Course> GetAll()
        {
            return _courseDal.GetAll();
        }

        public void Update(Course course)
        {
            _courseDal.Update(course); 
        }
    }
}
