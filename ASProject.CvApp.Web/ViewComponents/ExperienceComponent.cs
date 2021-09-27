using ASProject.CvApp.Business.Abstract;
using ASProject.CvApp.DTO.DTO.ExperienceDto;
using ASProject.CvApp.Entities.Concrete;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASProject.CvApp.Web.ViewComponents
{
    public class ExperienceComponent:ViewComponent
    {
        private readonly IGenericService<Experience> _genericExperienceService;
        private readonly IMapper _mapper;

        public ExperienceComponent(IGenericService<Experience> genericExperienceService, IMapper mapper)
        {
            _genericExperienceService = genericExperienceService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            return View(_mapper.Map<List<ExperienceListDto>>(_genericExperienceService.GetAll()));
        }
    }
}
