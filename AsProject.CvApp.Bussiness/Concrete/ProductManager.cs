using ASProject.CvApp.Business.Abstract;
using ASProject.CvApp.DataAccess.Abstract;
using ASProject.CvApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASProject.CvApp.Business.Concrete
{
    public class ProductManager : GenericManager<Product>, IProductService
    {
        
        private readonly IProductRepository _productRepository;

        public ProductManager(IGenericRepository<Product> genericRepository, IProductRepository productRepository):base(genericRepository)
        {
            
            _productRepository = productRepository;
        }

        
        public List<Product> GetProductDetails()
        {
          return _productRepository.GetProductDetails();
        }
    }
}
