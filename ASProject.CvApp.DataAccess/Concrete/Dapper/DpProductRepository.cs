using ASProject.CvApp.DataAccess.Abstract;
using ASProject.CvApp.Entities.Concrete;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ASProject.CvApp.DataAccess.Concrete.Dapper
{
    public class DpProductRepository : DpGenericRepository<Product>, IProductRepository
    {
        private readonly IDbConnection _dbConnection;
        public DpProductRepository(IDbConnection dbConnection) : base(dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public List<Product> GetProductDetails()
        {
            List<Product> products = _dbConnection.Query<Product>("Select p.* from Product p inner join Product_Category_Mapping pcm on p.Id=pcm.ProductId where TopMustCategoryId=@topMustCategoryId", new { topMustCategoryId = 10001 }).ToList();
             
            return products;
        }


    }
}
