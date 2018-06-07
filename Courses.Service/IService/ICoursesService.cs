using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Courses.Service.BEANS;

namespace Courses.Service.IService
{
    public interface ICoursesService
    {
        IList<CoursesBEAN> GetCourses();
    }
}
