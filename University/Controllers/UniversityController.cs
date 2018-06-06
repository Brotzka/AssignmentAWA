using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace University.Controllers
{
    public class UniversityController : Controller
    {
        private SheffieldService.Service.SheffieldUniversityService _SheffieldUniversityService;
        private University.Services.Service.UniversityService _UniversityService;

        public UniversityController()
        {
            _SheffieldUniversityService = new SheffieldService.Service.SheffieldUniversityService();
            _UniversityService = new University.Services.Service.UniversityService();
        }
        // GET: University
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetSheffCourses()
        {
            return View(_SheffieldUniversityService.GetSheffCoursesInShort());
        }

        public ActionResult GetUniversities()
        {
            return View(_UniversityService.GetUniversities());
        }
    }
}