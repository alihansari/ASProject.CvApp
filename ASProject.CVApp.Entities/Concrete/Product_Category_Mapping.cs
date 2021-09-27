using ASProject.CvApp.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASProject.CvApp.Entities.Concrete
{
    public class Product_Category_Mapping:IEntity
    {
        public int Id { get; set; }
        public Product  Product { get; set; }
        public Category  Category { get; set; }
        public int  ProductId { get; set; }
        public int  CategoryId { get; set; }
    }
}
