using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace University.Controllers
{
    public class UniversityController : Controller
    {
        private University.Services.Service.UniversityService _UniversityService;

        public UniversityController()
        {
            _UniversityService = new University.Services.Service.UniversityService();
        }

        public ActionResult GetUniversities()
        {
            return View(_UniversityService.GetUniversities());
        }
    }
}