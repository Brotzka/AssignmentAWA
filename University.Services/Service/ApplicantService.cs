using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Services.IService;
using University.Data;
using University.Data.IDAO;
using University.Data.DAO;

namespace University.Services.Service
{
    public class ApplicantService : IApplicantService
    {
        private IApplicantDAO _applicantDAO;

        public ApplicantService()
        {
            _applicantDAO = new ApplicantDAO();
        }
        public void AddApplicant(Applicant applicant)
        {
            _applicantDAO.AddApplicant(applicant);
        }

        public Applicant GetApplicant(int id)
        {
            return _applicantDAO.GetApplicant(id);
        }

        public Applicant EditApplicant(Applicant applicant)
        {
            return _applicantDAO.EditApplicant(applicant);
        }

        public void DeleteApplicant(Applicant applicant)
        {
            _applicantDAO.DeleteApplicant(applicant);
        }
    }
}
