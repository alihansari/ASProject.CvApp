using ASProject.CvApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASProject.CvApp.Business.Abstract
{
    public interface IProductService:IGenericService<Product>
    {
        List<Product> GetProductDetails();
    }
}
