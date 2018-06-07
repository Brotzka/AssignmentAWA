using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace University.Controllers
{
    public class MasterController : Controller
    {
        private University.Services.IService.IApplicantService _applicantService;
        public MasterController()
        {
            _applicantService = new University.Services.Service.ApplicantService();
            University.Data.Applicant applicant = _applicantService.GetApplicant(3);
            ViewBag.UserId = applicant.Id;
        }
    }
}