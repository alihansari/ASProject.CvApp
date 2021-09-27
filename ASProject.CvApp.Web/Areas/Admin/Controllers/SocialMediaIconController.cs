using ASProject.CvApp.Business.Abstract;
using ASProject.CvApp.DTO.DTO.SocialMediaIconDto;
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
    public class SocialMediaIconController : Controller
    {
        private readonly IAppUserService _appUserService;
        private readonly ISocialMediaIconService _socialMediaIconService;
        private readonly IMapper _mapper;

        public SocialMediaIconController(IAppUserService appUserService, ISocialMediaIconService socialMediaIconService, IMapper mapper)
        {
            _appUserService = appUserService;
            _socialMediaIconService = socialMediaIconService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            TempData["active"] = "icon";
            var user = _appUserService.FindByName(User.Identity.Name);
            return View(_mapper.Map<List<SocialMediaIconListDto>>(_socialMediaIconService.GetByUserId(user.Id)));
        }
        public IActionResult Add()
        {
            TempData["active"] = "icon";
            return View(new SocialMediaIconAddDto());
        }
        [HttpPost]
        public IActionResult Add(SocialMediaIconAddDto model)
        {
            TempData["active"] = "icon";
            if (ModelState.IsValid)
            {
                var user = _appUserService.FindByName(User.Identity.Name);
                model.AppUserId = user.Id;
                _socialMediaIconService.Insert(_mapper.Map<SocialMediaIcon>(model));
                TempData["message"] = "Ekleme işlemi başarılı";
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public IActionResult Update(int id)
        {
            TempData["active"] = "icon";
            return View(_mapper.Map<SocialMediaIconUpdateDto>(_socialMediaIconService.GetById(id)));
        }
        [HttpPost]
        public IActionResult Update(SocialMediaIconUpdateDto model)
        {
            TempData["active"] = "icon";
            if (ModelState.IsValid)
            {
                var user = _appUserService.FindByName(User.Identity.Name);
                var updatedSocialMediaIcon = _socialMediaIconService.GetById(model.Id);
                updatedSocialMediaIcon.AppUserId = user.Id;
                updatedSocialMediaIcon.Icon = model.Icon;
                updatedSocialMediaIcon.Link = model.Link;
                _socialMediaIconService.Update(updatedSocialMediaIcon);
                TempData["message"] = "Güncelleme İşlemi Başarılı";
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public IActionResult Delete(int id)
        {
            TempData["active"] = "icon";
            var deletedIcon = _socialMediaIconService.GetById(id);
            _socialMediaIconService.Delete(deletedIcon);
            TempData["message"] = "Silme İşlemi Başarılı";
            return RedirectToAction("Index");
        }
    }
}
