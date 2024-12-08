using ASProject.CvApp.Business.Abstract;
using ASProject.CvApp.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ASProject.CvApp.Web.Controllers
{
	public class HomeController : Controller
    {
        private readonly IGenericService<Skill> _skillService;
        public HomeController(IGenericService<Skill> skillService)
        {
            _skillService = skillService;
        }
        public IActionResult Index()
        { 
            return View();
        }
    }
}
