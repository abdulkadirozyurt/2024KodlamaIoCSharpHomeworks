using _01.Day2Hw3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Day2Hw3.Business.Abstract
{
    public interface ICategoryService
    {

        List<Category> GetAll();
        void Add(Category category);
        void Update(Category category);
        void Delete(Category category);



    }
}
