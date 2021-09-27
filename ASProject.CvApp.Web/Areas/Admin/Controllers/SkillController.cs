using ASProject.CvApp.Business.Abstract;
using ASProject.CvApp.DTO.DTO.SkillDto;
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
    [Authorize(Roles ="Admin")]
    public class SkillController:Controller
    {
        private readonly IGenericService<Skill> _genericSkillService;
        private readonly IMapper _mapper;

        public SkillController(IGenericService<Skill> genericSkillService, IMapper mapper)
        {
            _genericSkillService = genericSkillService;
            _mapper = mapper;
        }

        
        public IActionResult Index()
        {
            TempData["active"] = "skill";
            return View(_mapper.Map<List<SkillListDto>>(_genericSkillService.GetAll()));
        }
        public IActionResult Add()
        {
            TempData["active"] = "skill";
            return View(new SkillAddDto());
        }
        [HttpPost]
        public IActionResult Add(SkillAddDto model)
        {
            TempData["active"] = "skill";
            if (ModelState.IsValid)
            {
                _genericSkillService.Insert(_mapper.Map<Skill>(model));
                TempData["message"] = "Ekleme İşlemi Başarılı";
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public IActionResult Update(int id)
        {
            TempData["active"] = "skill";
            return View(_mapper.Map<SkillUpdateDto>(_genericSkillService.GetById(id)));
        }
        [HttpPost]
        public IActionResult Update(SkillUpdateDto model)
        {
            TempData["active"] = "skill";
            if (ModelState.IsValid)
            {
               var updatedSkill= _genericSkillService.GetById(model.Id);
                updatedSkill.Description = model.Description;
                _genericSkillService.Update(updatedSkill);
                TempData["message"] = "Güncelle İşleminiz başarılı";
                return RedirectToAction("Index");

            }
            return View(model);
        }
        public IActionResult Delete(int id)
        {
            TempData["active"] = "skill";
            var deletedSkill = _genericSkillService.GetById(id);
            _genericSkillService.Delete(deletedSkill);
            TempData["message"] = "Silme İşleminiz başarılı";
            return RedirectToAction("Index");
        }
    }
}
