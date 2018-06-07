using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Courses.Service.IService;
using Courses.Service.Service;

namespace University.Controllers
{
    public class CourseController : MasterController
    {
        private ICoursesService _coursesService;

        public ActionResult GetCourses(int UniversityId)
        {
            switch (UniversityId)
            {
                case 1:
                    _coursesService = new SheffieldCoursesService();
                    break;
                case 2:
                    _coursesService = new SHUCoursesService();
                    break;
                default:
                    return View();
            }
            return View(_coursesService.GetCourses());
        }
    }
}