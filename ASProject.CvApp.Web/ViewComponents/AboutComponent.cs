using ASProject.CvApp.Business.Abstract;
using ASProject.CvApp.DTO.DTO.AppUserListDto;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASProject.CvApp.Web.ViewComponents
{
    public class AboutComponent:ViewComponent
    {
        private readonly IAppUserService _appUserService;
        private readonly IMapper _mapper;

        public AboutComponent(IAppUserService appUserService, IMapper mapper)
        {
            _appUserService = appUserService;
            _mapper = mapper;
        }

        public  IViewComponentResult Invoke()
        {
            _appUserService.GetById(3);
            return View(_mapper.Map<AppUserListDto>(_appUserService.GetById(1)));
        }

    }
}
