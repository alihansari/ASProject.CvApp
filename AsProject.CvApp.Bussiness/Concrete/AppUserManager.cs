using ASProject.CvApp.Business.Abstract;
using ASProject.CvApp.DataAccess.Abstract;
using ASProject.CvApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASProject.CvApp.Business.Concrete
{
    public class AppUserManager : GenericManager<AppUser>,IAppUserService
    {
        
        private readonly IAppUserRepository _appUserRepository;

        public AppUserManager(IGenericRepository<AppUser> genericRepository, IAppUserRepository appUserRepository) : base(genericRepository)
        {
            
            _appUserRepository = appUserRepository;
        }

        public bool CheckUser(string userName, string password)
        {
            return _appUserRepository.CheckUser(userName,password);
        }

        public AppUser FindByName(string userName)
        {
            return _appUserRepository.FindByName(userName);
        }
        
    }
}
