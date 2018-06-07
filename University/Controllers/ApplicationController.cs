using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using University.Data;
using University.Services.IService;
using University.Services.Service;

namespace University.Controllers
{
    public class ApplicationController : MasterController
    {
        private IApplicationService _applicationService;

        public ApplicationController()
        {
            _applicationService = new ApplicationService();
        }
        // GET: Application
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateApplication(string CourseName, int UniversityId)
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateApplication(Application application)
        {
            _applicationService.CreateApplication(application);
            return RedirectToAction("GetApplications", new { userId=application.ApplicantId });
        }

        public ActionResult GetApplications(int userId)
        {
            return View(_applicationService.GetApplicationBEANS(userId));
        }
    }
}