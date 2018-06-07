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
            ViewBag.ShowAcceptLink = _applicationService.CanAcceptApplicationOffer(userId);
            return View(_applicationService.GetApplicationBEANS(userId));
        }

        public ActionResult DeleteApplication(int Id)
        {
            Application _application = _applicationService.GetApplication(Id);
            return View(_application);
        }

        [HttpPost]
        public ActionResult DeleteApplication(Application application)
        {
            Application _application = _applicationService.GetApplication(application.Id);
            _applicationService.DeleteApplication(_application);
            return RedirectToAction("GetApplications", new { userId = _application.ApplicantId });            
        }

        public ActionResult EditApplication(int Id)
        {
            Application _application = _applicationService.GetApplication(Id);
            return View(_application);
        }

        [HttpPost]
        public ActionResult EditApplication(Application application)
        {
            _applicationService.EditApplication(application);
            return RedirectToAction("GetApplications", new { userId = application.ApplicantId });
        }

        [HttpGet]
        public ActionResult AcceptApplicationOffer(int Id)
        {
            Application _application = _applicationService.GetApplication(Id);
            return View(_application);
        }

        [HttpPost]
        public ActionResult AcceptApplicationOffer(Application application)
        {
            try
            {
                _applicationService.AcceptApplicationOffer(application);
                return RedirectToAction("GetApplications", new { userId = application.ApplicantId });
            }catch (Exception ex)
            {
                return View();
            }
            
        }
    }
}