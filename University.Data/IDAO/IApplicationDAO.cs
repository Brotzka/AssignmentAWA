using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Data.BEANS;

namespace University.Data.IDAO
{
    public interface IApplicationDAO
    {
        void CreateApplication(Application application);

        Application GetApplication(int applicationId);

        IList<Application> GetApplications(int userId);

        IList<ApplicationBEAN> GetApplicationBEANS(int userId);

        void DeleteApplication(Application application);

        void EditApplication(Application application);

        IList<Application> GetAcceptedApplications(int userId);

        IList<ApplicationBEAN> GetUniversityApplicationBEANS(int universityId);
    }
}
