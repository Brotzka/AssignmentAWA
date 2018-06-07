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

        IList<Application> GetApplications(int userId);

        IList<ApplicationBEAN> GetApplicationBEANS(int userId);
        
    }
}
