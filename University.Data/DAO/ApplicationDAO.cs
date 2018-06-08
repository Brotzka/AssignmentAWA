using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Data.IDAO;
using University.Data.BEANS;

namespace University.Data.DAO
{
    public class ApplicationDAO : IApplicationDAO
    {
        private UniversityEntities _context;
        public ApplicationDAO()
        {
            _context = new UniversityEntities();
        }
        public void CreateApplication(Application application)
        {

            _context.Application.Add(application);
            _context.SaveChanges();
        }

        public Application GetApplication(int applicationId)
        {
            IQueryable<Application> _applications;
            _applications = from application in _context.Application
                            where application.Id == applicationId
                            select application;
            return _applications.ToList<Application>().First();
        }

        public IList<Application> GetApplications(int userId)
        {
            IQueryable<Application> _applications;
            _applications = from applications in _context.Application
                            where applications.ApplicantId == userId
                            select applications;
            return _applications.ToList();
        }

        public IList<ApplicationBEAN> GetApplicationBEANS(int userId)
        {
            IQueryable<ApplicationBEAN> _applicationBeans;
            _applicationBeans = from application in _context.Application
                                from applicant in _context.Applicant
                                from university in _context.University
                                where applicant.Id == userId
                                where application.ApplicantId == applicant.Id
                                where university.UniversityId == application.UniversityId
                                select new ApplicationBEAN
                                {
                                    ApplicationId = application.Id,
                                    ApplicantName = applicant.ApplicantName,
                                    ApplicantAddress = applicant.ApplicantAddress,
                                    ApplicantEmail = applicant.Email,
                                    ApplicantPhone = applicant.Phone,
                                    CourseName = application.CourseName,
                                    University = university.UniversityName,
                                    PersonalStatement = application.PersonalStatement,
                                    TeacherReference = application.TeacherReference,
                                    TeacherContactDetails = application.TeacherContactDetails,
                                    UniversityOffer = application.UniversityOffer,
                                    Firm = application.Firm
                                };
            return _applicationBeans.ToList<ApplicationBEAN>();
        }

        public void DeleteApplication(Application application)
        {
            _context.Application.Remove(application);
            _context.SaveChanges();
        }

        public void EditApplication(Application application)
        {
            Application _application = GetApplication(application.Id);
            
            _application.PersonalStatement = application.PersonalStatement;
            _application.TeacherContactDetails = application.TeacherContactDetails;
            _application.TeacherReference = application.TeacherReference;
            _application.Firm = application.Firm;
            _application.UniversityOffer = application.UniversityOffer;
            _context.SaveChanges();
        }

        public IList<Application> GetAcceptedApplications(int userId)
        {
            IQueryable<Application> _applications;
            _applications = from applications in _context.Application
                            where applications.ApplicantId == userId
                            where applications.Firm == true
                            select applications;
            return _applications.ToList();
        }

        public IList<ApplicationBEAN> GetUniversityApplicationBEANS(int universityId)
        {
            IQueryable<ApplicationBEAN> _applicationBeans;
            _applicationBeans = from application in _context.Application
                                from applicant in _context.Applicant
                                from university in _context.University
                                where application.UniversityId == universityId
                                where application.ApplicantId == applicant.Id
                                where university.UniversityId == application.UniversityId
                                select new ApplicationBEAN
                                {
                                    ApplicationId = application.Id,
                                    ApplicantName = applicant.ApplicantName,
                                    ApplicantAddress = applicant.ApplicantAddress,
                                    ApplicantEmail = applicant.Email,
                                    ApplicantPhone = applicant.Phone,
                                    CourseName = application.CourseName,
                                    University = university.UniversityName,
                                    PersonalStatement = application.PersonalStatement,
                                    TeacherReference = application.TeacherReference,
                                    TeacherContactDetails = application.TeacherContactDetails,
                                    UniversityOffer = application.UniversityOffer,
                                    Firm = application.Firm
                                };
            return _applicationBeans.ToList<ApplicationBEAN>();
        }

        public IList<ApplicationBEAN> GetUniversityApplicationBEANSByCourseName(int universityId, string CourseName)
        {
            IQueryable<ApplicationBEAN> _applicationBeans;
            _applicationBeans = from application in _context.Application
                                from applicant in _context.Applicant
                                from university in _context.University
                                where application.UniversityId == universityId
                                where application.ApplicantId == applicant.Id
                                where university.UniversityId == application.UniversityId
                                where application.CourseName == CourseName
                                select new ApplicationBEAN
                                {
                                    ApplicationId = application.Id,
                                    ApplicantName = applicant.ApplicantName,
                                    ApplicantAddress = applicant.ApplicantAddress,
                                    ApplicantEmail = applicant.Email,
                                    ApplicantPhone = applicant.Phone,
                                    CourseName = application.CourseName,
                                    University = university.UniversityName,
                                    PersonalStatement = application.PersonalStatement,
                                    TeacherReference = application.TeacherReference,
                                    TeacherContactDetails = application.TeacherContactDetails,
                                    UniversityOffer = application.UniversityOffer,
                                    Firm = application.Firm
                                };
            return _applicationBeans.ToList<ApplicationBEAN>();
        }
    }
}
