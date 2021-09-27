using ASProject.CvApp.Business.Abstract;
using ASProject.CvApp.DTO.DTO.InterestDto;
using ASProject.CvApp.Entities.Concrete;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASProject.CvApp.Web.ViewComponents
{
    public class InterestComponent:ViewComponent
    {
        private readonly IGenericService<Interest> _genericInterestService;
        private readonly IMapper _mapper;
        public InterestComponent(IGenericService<Interest> genericInterestService, IMapper mapper)
        {
            _genericInterestService = genericInterestService;
            _mapper = mapper;
        }


        public IViewComponentResult Invoke()
        {
            return View(_mapper.Map<List<InterestListDto>>(_genericInterestService.GetAll()));
        }
    }
}
