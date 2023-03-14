using Shopping.Business.Abstract;
using Shopping.DataAccess.Abstract;
using Shopping.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {

        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            List<Category> list;
            list = _categoryDal.GetAll();
            list.Insert(0, new Category
            {
                CategoryId = -1,
                CategoryName = "Tüm Ürünler"
            });

            return list;
        }
    }
}
