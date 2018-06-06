using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheffieldHallamService.Service
{
    public class SheffieldHallamUniversityService : IService.ISheffieldHallamUniversityService
    {
        private SheffieldHallam.Service.SheffieldHallamService.SHUWebService _proxy;

        public SheffieldHallamUniversityService()
        {
            _proxy = new SheffieldHallam.Service.SheffieldHallamService.SHUWebService();
        }

        public IList<SheffieldHallam.Service.SheffieldHallamService.SHUCourse> GetSheffHallamCourses()
        {
            return _proxy.SHUCourses();
        }
    }
}
