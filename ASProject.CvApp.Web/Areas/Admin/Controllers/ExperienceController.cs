using ASProject.CvApp.Business.Abstract;
using ASProject.CvApp.DTO.DTO.ExperienceDto;
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
    [Authorize(Roles = "Admin")]
    public class ExperienceController : Controller
    {
        private readonly IGenericService<Experience> _genericExperienceService;
        private readonly IMapper _mapper;

        public ExperienceController(IGenericService<Experience> genericExperienceService, IMapper mapper)
        {
            _genericExperienceService = genericExperienceService;
            _mapper = mapper;
        }


        public IActionResult Index()
        {
            TempData["active"] = "experience";
            return View(_mapper.Map<List<ExperienceListDto>>(_genericExperienceService.GetAll()));
        }
        public IActionResult Add()
        {
            TempData["active"] = "experience";
            return View(new ExperienceAddDto());
        }
        [HttpPost]
        public IActionResult Add(ExperienceAddDto model)
        {
            TempData["active"] = "experience";
            if (ModelState.IsValid)
            {
                TempData["message"] = "Ekleme İşleminiz başarı ile gerçekleşti";
                _genericExperienceService.Insert(_mapper.Map<Experience>(model));
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Update(int id)
        {
            TempData["active"] = "experience";
            return View(_mapper.Map<ExperienceUpdateDto>(_genericExperienceService.GetById(id)));
        }
        [HttpPost]
        public IActionResult Update(ExperienceUpdateDto model)
        {
            TempData["active"] = "experience";
            if (ModelState.IsValid)
            {
                var updatedExperience = _genericExperienceService.GetById(model.Id);
                updatedExperience.Description = model.Description;
                updatedExperience.StartDate = model.StartDate;
                updatedExperience.EndDate = model.EndDate;
                updatedExperience.SubTitle = model.SubTitle;
                updatedExperience.Title = model.Title;
                _genericExperienceService.Update(updatedExperience);
                TempData["message"] = "Güncelleme İşleminiz Başarı İle Gerçekleşti";
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public IActionResult Delete(int id)
        {
            TempData["active"] = "experience";
            var deletedExperience = _genericExperienceService.GetById(id);
            _genericExperienceService.Delete(deletedExperience);
            TempData["message"] = "Silme İşleminiz Başarı İle Gerçekleşti";
            return RedirectToAction("Index");
        }
    }
}


