using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Data.IDAO;

namespace University.Data.DAO
{
    public class ApplicantDAO : IApplicantDAO
    {
        private UniversityEntities _context;
        public ApplicantDAO()
        {
            _context = new UniversityEntities();
        }

        public void AddApplicant(Applicant applicant)
        {
            _context.Applicant.Add(applicant);
            _context.SaveChanges();
        }

        public Applicant GetApplicant(int id)
        {
            IQueryable<Applicant> _applicant;
            _applicant  = from applicant
                          in _context.Applicant
                          where applicant.Id == id
                          select applicant;

            if(_applicant.ToList<Applicant>().Count() == 0)
            {
                // TODO: Exception werfen und im Controller handlen
                return new Applicant();
            }
            return _applicant.ToList<Applicant>().First();
        }

        public Applicant EditApplicant(Applicant applicant)
        {
            Applicant _applicant = GetApplicant(applicant.Id);

            _applicant.ApplicantName = applicant.ApplicantName;
            _applicant.ApplicantAddress = applicant.ApplicantAddress;
            _applicant.Phone = applicant.Phone;
            _applicant.Email = applicant.Email;
            _context.SaveChanges();
            return _applicant;
        }

        public void DeleteApplicant(Applicant applicant)
        {
            _context.Applicant.Remove(applicant);
            _context.SaveChanges();
        }
    }
}
