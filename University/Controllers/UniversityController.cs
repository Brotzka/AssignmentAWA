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

        public UniversityController()
        {
            _SheffieldUniversityService = new SheffieldService.Service.SheffieldUniversityService();
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
    }
}