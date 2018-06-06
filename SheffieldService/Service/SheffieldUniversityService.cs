using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheffieldService.Service
{
    public class SheffieldUniversityService : IService.ISheffieldUniversityService
    {
        private SheffieldService.SheffieldWebService _proxy;

        public SheffieldUniversityService()
        {
            _proxy = new SheffieldService.SheffieldWebService();
        }

        public IList<SheffieldService.Course> GetSheffCoursesInShort()
        {
            return _proxy.SheffCourses();
        }
    }
}
