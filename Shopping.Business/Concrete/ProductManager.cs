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
    public class ProductManager : IProductService
    {

        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            try
            {
                _productDal.Delete(product);
            }
            catch
            {
                throw new Exception("Hata");
            }
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<Product> GetProductsByCategory(int categoryId)
        {
            if(categoryId < 1)
            {
                return _productDal.GetAll();
            } 
            else
            {
                return _productDal.GetAll(p => p.CategoryId == categoryId);
            }          
        }

        public List<Product> GetProductsByProductName(string productName, int categoryId=-1)
        {
            if (categoryId == -1)
            {
                return _productDal.GetAll(p => p.ProductName.ToLower().Contains(productName.ToLower()));
            }
            else
            {
                return _productDal.GetAll(p => p.ProductName.ToLower().Contains(productName.ToLower()) && p.CategoryId == categoryId);
            }
             
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
