using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using University.Data;

namespace University.Controllers
{
    public class ApplicantController : MasterController
    {
        private University.Services.IService.IApplicantService _applicantService;
        public ApplicantController()
        {
            _applicantService = new University.Services.Service.ApplicantService();
        }
        // GET: Applicant
        public ActionResult Details()
        {
            return View();
        }

        // GET: Applicant/Details/5
        public ActionResult GetApplicant(int id)
        {
            setCurrentApplicantId(id);
            return View(_applicantService.GetApplicant(id));
        }

        // GET: Applicant/Create
        public ActionResult AddApplicant()
        {
            return View();
        }

        // POST: Applicant/Create
        [HttpPost]
        public ActionResult AddApplicant( Applicant applicant )
        {
            try
            {
                
                _applicantService.AddApplicant(applicant);
                return RedirectToAction("GetApplicant", new { id = applicant.Id });
            }
            catch
            {
                return View();
            }
        }

        // GET: Applicant/Edit/5
        public ActionResult EditApplicant(int id)
        {
            return View(_applicantService.GetApplicant(id));
        }

        // POST: Applicant/Edit/5
        [HttpPost]
        public ActionResult EditApplicant(int id, Applicant applicant)
        {
            try
            {
                // TODO: Add update logic here
                Applicant _applicant = _applicantService.EditApplicant(applicant);
                return RedirectToAction("GetApplicant", new { id = applicant.Id });
            }
            catch
            {
                return View();
            }
        }

        // GET: Applicant/Delete/5
        public ActionResult DeleteApplicant(int id)
        {
            Applicant _applicant = _applicantService.GetApplicant(id);
            return View(_applicant);
        }

        // POST: Applicant/Delete/5
        [HttpPost]
        public ActionResult DeleteApplicant(Applicant applicant)
        {
            try
            {
                Applicant _applicant = _applicantService.GetApplicant(applicant.Id);
                _applicantService.DeleteApplicant(_applicant);

                return Redirect("/");
            }
            catch
            {
                return View();
            }
        }
    }
}
