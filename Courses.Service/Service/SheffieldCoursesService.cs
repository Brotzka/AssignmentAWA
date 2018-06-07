using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Courses.Service.BEANS;
using Courses.Service.IService;
using Courses.Service.SheffieldWebService;

namespace Courses.Service.Service
{
    public class SheffieldCoursesService : ICoursesService
    {
        private SheffieldWebService.SheffieldWebService _proxy;

        public SheffieldCoursesService()
        {
            _proxy = new SheffieldWebService.SheffieldWebService();
        }

        public IList<CoursesBEAN> GetCourses()
        {
            IList<Course> _SheffieldCoursesList = _proxy.SheffCourses();
            IList<CoursesBEAN> _coursesList = new List<CoursesBEAN>();
            foreach (Course SheffieldCourse in _SheffieldCoursesList)
            {
                CoursesBEAN _bean = new CoursesBEAN();
                _bean.Id = SheffieldCourse.Id;
                _bean.Name = SheffieldCourse.Name;
                _bean.Description = SheffieldCourse.Description;
                _bean.Requirements = SheffieldCourse.EntryReq;
                _bean.Tarif = SheffieldCourse.Tarif.ToString();
                _bean.NSS = SheffieldCourse.NSS.ToString();
                _bean.Degree = SheffieldCourse.Qulaification;
                _coursesList.Add(_bean);
            }

            return _coursesList;
        }
    }
}
