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
    public class DpSocialMediaIcon : DpGenericRepository<SocialMediaIcon>, ISocialMediaIconRepository
    {
        private readonly IDbConnection _connection;
        public DpSocialMediaIcon(IDbConnection connection) :base(connection)
        {
            _connection = connection;
        }

        public List<SocialMediaIcon> GetByUserId(int userId)
        {
            return _connection.Query<SocialMediaIcon>("Select * from SocialMediaIcons where AppUserId=@id", new { id = userId }).ToList();
        }
    }
}
