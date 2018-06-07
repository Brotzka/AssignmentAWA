using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Courses.Service.BEANS;
using Courses.Service.IService;
using Courses.Service.SHUWebService;

namespace Courses.Service.Service
{
    public class SHUCoursesService : ICoursesService
    {
        private SHUWebService.SHUWebService _proxy;

        public SHUCoursesService()
        {
            _proxy = new SHUWebService.SHUWebService();
        }

        public IList<CoursesBEAN> GetCourses()
        {
            IList<SHUCourse> _SHUCoursesList = _proxy.SHUCourses();
            IList<CoursesBEAN> _coursesList = new List<CoursesBEAN>();
            foreach (SHUCourse SHUCourse in _SHUCoursesList)
            {
                CoursesBEAN _bean = new CoursesBEAN();
                _bean.Id = SHUCourse.CourseId;
                _bean.Name = SHUCourse.CName;
                _bean.Description = SHUCourse.CDescription;
                _bean.Requirements = SHUCourse.CRequirements;
                _bean.Tarif = SHUCourse.CTarif;
                _bean.NSS = SHUCourse.CNSS;
                _bean.Degree = SHUCourse.CDegree;
                _coursesList.Add(_bean);
            }
            
            return _coursesList;
        }
    }
}
