using ASProject.CvApp.Business.Abstract;
using ASProject.CvApp.DTO.DTO.EducationDto;
using ASProject.CvApp.Entities.Concrete;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ASProject.CvApp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class EducationController:Controller
    {

        private readonly IGenericService<Education> _educationGenericService;
        private readonly IMapper _mapper;

        public EducationController(IGenericService<Education> educationGenericService, IMapper mapper)
        {
            _educationGenericService = educationGenericService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            TempData["active"] = "education";
            return View(_mapper.Map<List<EducationListDto>>(_educationGenericService.GetAll()));
        }
        public IActionResult Delete(int id)
        {
            TempData["active"] = "education";
            var deletedEntity = _educationGenericService.GetById(id);
            _educationGenericService.Delete(deletedEntity);
            TempData["message"] = "Silme İşlemi Başarılı";
            return RedirectToAction("Index");
        }
        public IActionResult Add()
        {
            TempData["active"] = "education";
            return View(new EducationAddDto());
        }
        [HttpPost]
        public IActionResult Add(EducationAddDto model)
        {
            TempData["active"] = "education";
            if (ModelState.IsValid)
            {
                _educationGenericService.Insert(_mapper.Map<Education>(model));
                TempData["message"] = "Ekleme  İşlemi Başarılı";
                return RedirectToAction("Index");
            }
            
            return View(model);
        }
        public IActionResult Update(int id)
        {
            TempData["active"] = "education";
            return View(_mapper.Map<EducationUpdateDto>(_educationGenericService.GetById(id)));
        }
        [HttpPost]
        public IActionResult Update(EducationUpdateDto model)
        {
            if (ModelState.IsValid)
            {
                var updatedEducation = _educationGenericService.GetById(model.Id);
                updatedEducation.StartDate = model.StartDate;
                updatedEducation.SubTitle = model.SubTitle;
                updatedEducation.Title = model.Title;
                updatedEducation.Description = model.Description;
                updatedEducation.EndDate = model.EndDate;
                _educationGenericService.Update(updatedEducation);
                TempData["message"] = "Güncelleme işlemi başarı ile gerçekleşti";
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
