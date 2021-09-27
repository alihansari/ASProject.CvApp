using ASProject.CvApp.DataAccess.Abstract;
using ASProject.CvApp.Entities.Abstract;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ASProject.CvApp.DataAccess.Concrete.Dapper
{
    public class DpGenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class, IEntity, new()
    {
        private readonly IDbConnection _dbconnection;
        public DpGenericRepository(IDbConnection dbconnection)
        {
            _dbconnection = dbconnection;
        }
        public void Delete(TEntity entity)
        {
            _dbconnection.Delete(entity);
        }

        public List<TEntity> GetAll()
        {
            return _dbconnection.GetAll<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return _dbconnection.Get<TEntity>(id);
        }

        public void Insert(TEntity entity)
        {
            _dbconnection.Insert(entity);
        }

        public void Update(TEntity entity)
        {
            _dbconnection.Update(entity);
        }
    }
}
