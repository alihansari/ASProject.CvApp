using ASProject.CvApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASProject.CvApp.DataAccess.Abstract
{
    public interface IProductRepository:IGenericRepository<Product>
    {
        List<Product> GetProductDetails();
    }
}
