using ASProject.CvApp.DataAccess.Abstract;
using ASProject.CvApp.Entities.Concrete;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ASProject.CvApp.DataAccess.Concrete.Dapper
{
    public class DpAppUserRepository:DpGenericRepository<AppUser>,IAppUserRepository
    {
        private readonly IDbConnection _dbConnection;
        public DpAppUserRepository(IDbConnection dbConnection):base(dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public bool CheckUser(string userName, string password)
        {
           var user=_dbConnection.QueryFirstOrDefault<AppUser>("Select * from AppUsers where UserName=@username and Password=@password",new { userName=userName,password=password});
            return user != null;

        }

        public AppUser FindByName(string userName)
        {
           return _dbConnection.QueryFirstOrDefault<AppUser>("Select *  from AppUsers where UserName = @userName", new { userName = userName });
        }
    }
}
