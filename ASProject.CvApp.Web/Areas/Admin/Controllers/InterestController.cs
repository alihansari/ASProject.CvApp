using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASProject.CvApp.Entities.Concrete;
using ASProject.CvApp.Business.Abstract;
using AutoMapper;
using ASProject.CvApp.DTO.DTO.InterestDto;

namespace ASProject.CvApp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class InterestController : Controller
    {
        private readonly IGenericService<Interest> _genericInterestService;
        private readonly IMapper _mapper;

        public InterestController(IGenericService<Interest> genericInterestService, IMapper mapper)
        {
            _genericInterestService = genericInterestService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            TempData["active"] = "hobby";
            return View(_mapper.Map<List<InterestListDto>>(_genericInterestService.GetAll()));
        }
        public IActionResult Add()
        {
            TempData["active"] = "hobby";
            return View(new InterestAddDto());
        }
        [HttpPost]
        public IActionResult Add(InterestAddDto model)
        {
            TempData["active"] = "hobby";
            if (ModelState.IsValid)
            {
                _genericInterestService.Insert(_mapper.Map<Interest>(model));
                TempData["message"] = "Ekleme işleminiz başarılı";
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public IActionResult Update(int id)
        {
            TempData["active"] = "hobby";
            return View(_mapper.Map<InterestUpdateDto>(_genericInterestService.GetById(id)));
        }
        [HttpPost]
        public IActionResult Update(InterestUpdateDto model)
        {
            TempData["active"] = "hobby";
            if (ModelState.IsValid)
            {
                var updatedInterest=_genericInterestService.GetById(model.Id);
                updatedInterest.Description = model.Description;
                _genericInterestService.Update(updatedInterest);
                TempData["message"] = "Güncelleme İşlemi Başarılı";
                return RedirectToAction("Index");

            }
            return View(model);
        }
        public IActionResult Delete(int id)
        {
            TempData["active"] = "hobby";
            var deletedInterest=_genericInterestService.GetById(id);
            _genericInterestService.Delete(deletedInterest);
            TempData["message"] = "Silme İşlemi Başarılı";
            return RedirectToAction("Index");
        }
    }
}
