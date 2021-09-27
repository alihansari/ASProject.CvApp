using ASProject.CvApp.Business.Abstract;
using ASProject.CvApp.DTO.DTO.CertificationDto;
using ASProject.CvApp.Entities.Concrete;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASProject.CvApp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles="Admin")]
    public class CertificationController:Controller
    {
        private readonly IGenericService<Certification> _certificationGenericService;
        private readonly IMapper _mapper;

        public CertificationController(IGenericService<Certification> certificationGenericService, IMapper mapper)
        {
            _certificationGenericService = certificationGenericService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            TempData["active"] = "certification";
            return View(_mapper.Map<List<CertificationListDto>>(_certificationGenericService.GetAll()));
        }

        public IActionResult Delete(int id)
        {
            TempData["active"] = "certification";
            var deletedEntity = _certificationGenericService.GetById(id);

            _certificationGenericService.Delete(deletedEntity);
            TempData["message"] = "Sertifika Silindi";
            return RedirectToAction("Index");
        }
        public IActionResult Add()
        {
            TempData["active"] = "certification";
            return View(new CertificationAddDto());
        }
        [HttpPost]
        public IActionResult Add(CertificationAddDto model)
        {
            TempData["active"] = "certification";
            if (ModelState.IsValid)
            {
                _certificationGenericService.Insert(_mapper.Map<Certification>(model));
                TempData["message"] = "Sertifika Eklendi";
                return RedirectToAction("Index");
            }
            return View(new CertificationAddDto());
        }
        public IActionResult Update(int id)
        {
            TempData["active"] = "certification";
            return View(_mapper.Map<CertificationUpdateDto>(_certificationGenericService.GetById(id)));

        }
        [HttpPost]
        public IActionResult Update(CertificationUpdateDto model)
        {
            TempData["active"] = "certification";
            if (ModelState.IsValid)
            {
                var updatedCertification = _certificationGenericService.GetById(model.Id);
                updatedCertification.Description = model.Description;
                _certificationGenericService.Update(updatedCertification);
                TempData["message"] = "Güncelleme Başarılı";
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
