using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal; 
        }
        public List<Category> GetAll()
        {
           return _categoryDal.GetAll();
        }

        public Category GetById(int categoryId)
        {
            // Get method is used to get a single category by id because we are using Expression<Func<Category, bool>>
            return _categoryDal.Get(c => c.CategoryId == categoryId);
        }
    }
}
