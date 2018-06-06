using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Data.IDAO
{
    public interface IUniversityDAO
    {
        IList<University> GetUniversities();
    }
}
