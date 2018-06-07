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

        public Application GetApplication(int applicationId)
        {
            return _applicationDAO.GetApplication(applicationId);
        }

        public IList<Application> GetApplications(int userId)
        {
            return _applicationDAO.GetApplications(userId);
        }

        public IList<ApplicationBEAN> GetApplicationBEANS(int userId)
        {
            return _applicationDAO.GetApplicationBEANS(userId);
        }

        public void DeleteApplication(Application application)
        {
            string _offer = application.UniversityOffer;
            if(_offer == "P")
            {
                _applicationDAO.DeleteApplication(application);
            }else
            {
                throw new Exception("Not allowed to delete Application!");
            }
            
        }

        public void EditApplication(Application application)
        {
            string _offer = application.UniversityOffer;
            if (_offer == "P" || _offer == "C")
            {
                _applicationDAO.EditApplication(application);
            }
            else
            {
                throw new Exception("Not allowed to edit Application!");
            }

        }

        public void AcceptApplicationOffer(Application application)
        {
            string _offer = application.UniversityOffer;

            if ((_offer == "U" || _offer == "C") && CanAcceptApplicationOffer(application.ApplicantId))
            {
                application.Firm = true;
                _applicationDAO.EditApplication(application);
            }
            else
            {
                throw new Exception("Not allowed to accept Application!");
            }
        }

        public bool CanAcceptApplicationOffer(int userId)
        {
            IList<Application> _applications = _applicationDAO.GetAcceptedApplications(userId);
            return _applications.Count() == 0;
        }
    }
}
