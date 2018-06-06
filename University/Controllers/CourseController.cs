using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace University.Controllers
{
    public class CourseController : Controller
    {
        private SheffieldService.Service.SheffieldUniversityService _SheffieldUniversityService;
        private SheffieldHallamService.Service.SheffieldHallamUniversityService _SheffieldHallamUniversityService;

        public CourseController()
        {
            _SheffieldUniversityService = new SheffieldService.Service.SheffieldUniversityService();
            _SheffieldHallamUniversityService = new SheffieldHallamService.Service.SheffieldHallamUniversityService();

        }

        public ActionResult GetSheffieldCourses(int UniversityId)
        {
            ViewBag.UniversityId = UniversityId;
            return View(_SheffieldUniversityService.GetSheffCoursesInShort());
        }


        public ActionResult GetSheffieldHallamCourses(int UniversityId)
        {
            ViewBag.UniversityId = UniversityId;
            return View(_SheffieldHallamUniversityService.GetSheffHallamCourses());
        }
    }
}