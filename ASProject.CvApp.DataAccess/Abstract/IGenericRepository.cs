using ASProject.CvApp.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASProject.CvApp.DataAccess.Abstract
{
    public interface IGenericRepository<TEntity> where TEntity:class,IEntity,new()
    {
        List<TEntity> GetAll();
        TEntity GetById(int id);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
