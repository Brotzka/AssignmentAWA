using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Services.IService
{
    interface IUniversityService
    {
        IList<University.Data.University> GetUniversities();
    }
}
