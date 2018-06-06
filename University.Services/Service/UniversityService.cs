using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Data;
using University.Services.IService;
using University.Data.IDAO;
using University.Data.DAO;

namespace University.Services.Service
{
    public class UniversityService : IService.IUniversityService
    {
        private IUniversityDAO _universityDAO;

        public UniversityService()
        {
            _universityDAO = new UniversityDAO();
        }

        public IList<Data.University> GetUniversities()
        {
            return _universityDAO.GetUniversities();
        }
    }
}
