using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Data;
using University.Data.BEANS;
using University.Data.IDAO;
using University.Data.DAO;
using University.Services.IService;

namespace University.Services.Service
{
    public class ApplicationService : IApplicationService
    {
        private IApplicationDAO _applicationDAO;

        public ApplicationService()
        {
            _applicationDAO = new ApplicationDAO();
        }
        public void CreateApplication(Application application)
        {
            application.UniversityOffer = "P";
            application.Firm = false;
            IList<Application> applicationList = _applicationDAO.GetApplications(application.ApplicantId);
            if(applicationList.Count() < 5)
            {
                _applicationDAO.CreateApplication(application);
            }
        }

        public IList<Application> GetApplications(int userId)
        {
            return _applicationDAO.GetApplications(userId);
        }

        public IList<ApplicationBEAN> GetApplicationBEANS(int userId)
        {
            return _applicationDAO.GetApplicationBEANS(userId);
        }
    }
}
