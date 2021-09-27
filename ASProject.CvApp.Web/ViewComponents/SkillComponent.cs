using ASProject.CvApp.Business.Abstract;
using ASProject.CvApp.DTO.DTO.SkillDto;
using ASProject.CvApp.Entities.Concrete;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASProject.CvApp.Web.ViewComponents
{
    public class SkillComponent:ViewComponent
    {
        private readonly IGenericService<Skill> _genericSkillService;
        private readonly IMapper _mapper;
        public SkillComponent(IGenericService<Skill> genericSkillService, IMapper mapper)
        {
            _genericSkillService = genericSkillService;
            _mapper = mapper;
        }


        public IViewComponentResult Invoke()
        {
            return View(_mapper.Map<List<SkillListDto>>(_genericSkillService.GetAll()));
        }
    }
}
