using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Data;

namespace University.Services.IService
{
    public  interface IApplicantService
    {
        void AddApplicant(Applicant applicant);

        Applicant GetApplicant(int id);

        Applicant EditApplicant(Applicant applicant);

        void DeleteApplicant(Applicant applicant);
    }
}
