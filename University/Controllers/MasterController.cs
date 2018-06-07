using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace University.Controllers
{
    public class MasterController : Controller
    {
        private static int _currentApplicantId;
        public MasterController()
        {
            ViewBag.UserId = _currentApplicantId;
        }

        public void setCurrentApplicantId(int userId)
        {
            _currentApplicantId = userId;
            ViewBag.UserId = _currentApplicantId;
        }
    }
}