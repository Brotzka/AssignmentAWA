using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Data.IDAO
{
    public interface IApplicantDAO
    {
        void AddApplicant(Applicant applicant);

        Applicant GetApplicant(int id);

        Applicant EditApplicant(Applicant applicant);

        void DeleteApplicant(Applicant applicant);

    }

    
}
