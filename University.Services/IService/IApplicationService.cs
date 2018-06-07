using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Data;
using University.Data.BEANS;

namespace University.Services.IService
{
    public interface IApplicationService
    {
        void CreateApplication(Application application);

        Application GetApplication(int applicationId);

        IList<Application> GetApplications(int userId);

        IList<ApplicationBEAN> GetApplicationBEANS(int userId);

        void DeleteApplication(Application application);

        void EditApplication(Application application);

        void AcceptApplicationOffer(Application application);

        bool CanAcceptApplicationOffer(int userId);
    }
}
