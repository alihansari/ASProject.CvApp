using ASProject.CvApp.Business.Abstract;
using ASProject.CvApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASProject.CvApp.Business.Abstract
{
    public interface IAppUserService:IGenericService<AppUser>
    {
        /// <summary>
        /// Eğer kullanıcı var ise true döner, yok  ise false döner
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        bool CheckUser(string userName, string password);
        AppUser FindByName(string userName);
    }
}
