using ASProject.CvApp.Business.Abstract;
using ASProject.CvApp.DTO.DTO.CertificationDto;
using ASProject.CvApp.Entities.Concrete;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASProject.CvApp.Web.ViewComponents
{
    public class CertificationComponent:ViewComponent
    {
        private readonly IGenericService<Certification> _genericCertificationService;
        private readonly IMapper _mapper;
        public CertificationComponent(IGenericService<Certification> genericCertificationService, IMapper mapper)
        {
            _genericCertificationService = genericCertificationService;
            _mapper = mapper;
        }
        public IViewComponentResult Invoke()
        {
            return View(_mapper.Map<List<CertificationListDto>>(_genericCertificationService.GetAll()));
        }
    }
}
