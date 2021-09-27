using ASProject.CvApp.Entities.Abstract;
using ASProject.CvApp.Entities.Concrete.BaseClasses;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASProject.CvApp.Entities.Concrete
{
    /*Id,ProductTypeId,ParentGroupedProductId,Name,WebName,ShortDescription,FullDescription,ShowOnHomePage,Sku,DisplayOrder,Published,Deleted,CreatedOnUtc,UpdatedOnUtc,ProductCode,Language,IsNew,Isbn,PublishedOnUtc,StockQuantity,Price,OldPrice*/
    [Table("Product")]
    public class Product : BaseEntityT, IEntity
    {
        public int ProductTypeId { get; set; }
        public int ParentGroupedProductId { get; set; }
        public string Name { get; set; }
        public string WebName { get; set; }
        public int DisplayOrder { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
        public bool ShowOnHomePage { get; set; }
        public string AdminComment { get; set; }
        public string Sku { get; set; }
        public int? StockQuantity { get; set; }
        public decimal Price { get; set; }
        public bool Published { get; set; }
        public bool Deleted { get; set; }
        public string ProductCode { get; set; }
        public string Isbn { get; set; }
        public List<Product_Picture_Mapping> Picture_Mappings { get; set; }
        public List<Product_Category_Mapping> Product_Category_Mappings { get; set; }
    }
}
