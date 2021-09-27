using ASProject.CvApp.Entities.Abstract;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASProject.CvApp.Entities.Concrete
{
    public class Product_Picture_Mapping:IEntity
    {
        [Key]
        public int Id { get; set; }  
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int PictureId { get; set; }
        public Picture Picture { get; set; }
        public int DisplayOrder { get; set; }
        public int TypeId { get; set; }
    }
}
