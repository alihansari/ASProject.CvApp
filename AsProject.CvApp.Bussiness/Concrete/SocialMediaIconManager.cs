using ASProject.CvApp.Business.Abstract;
using ASProject.CvApp.DataAccess.Abstract;
using ASProject.CvApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASProject.CvApp.Business.Concrete
{
    public class SocialMediaIconManager : GenericManager<SocialMediaIcon>, ISocialMediaIconService
    {

        private readonly ISocialMediaIconRepository _socialMediaIconRepository;
        public SocialMediaIconManager(IGenericRepository<SocialMediaIcon> genericSocialMediaIconRepository, ISocialMediaIconRepository socialMediaIconRepository) : base(genericSocialMediaIconRepository)
        {

            _socialMediaIconRepository = socialMediaIconRepository;
        }
        public List<SocialMediaIcon> GetByUserId(int userId)
        {
            return _socialMediaIconRepository.GetByUserId(userId);
        }
    }
}
