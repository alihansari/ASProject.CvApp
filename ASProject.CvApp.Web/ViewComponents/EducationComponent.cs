using ASProject.CvApp.Business.Abstract;
using ASProject.CvApp.DTO.DTO.EducationDto;
using ASProject.CvApp.Entities.Concrete;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASProject.CvApp.Web.ViewComponents
{
    public class EducationComponent:ViewComponent
    {
        private readonly IGenericService<Education> _genericEducationService;
        private readonly IMapper _mapper;
        public EducationComponent(IGenericService<Education> genericEducationService, IMapper mapper)
        {
            _genericEducationService = genericEducationService;
            _mapper = mapper;
        }


        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(_mapper.Map <List<EducationListDto>>(_genericEducationService.GetAll()));
        }
    }
}
