using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheffieldHallamService.IService
{
    interface ISheffieldHallamUniversityService
    {
        IList<SheffieldHallam.Service.SheffieldHallamService.SHUCourse> GetSheffHallamCourses();
    }
}
