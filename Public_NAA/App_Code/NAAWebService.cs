using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using University.Services.IService;
using University.Services.Service;
using University.Data.BEANS;
using University.Data;

/// <summary>
/// Summary description for NAAWebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class NAAWebService : System.Web.Services.WebService
{
    private ApplicationService _applicationService;
    
    public NAAWebService()
    {
        _applicationService = new ApplicationService();
    }

    [WebMethod]
    public string HelloWorld()
    {
        return "Hello World";
    }

    [WebMethod]
    public List<ApplicationBEAN> GetAllApplications(int UniversityId)
    {
        return _applicationService.GetUniversityApplicationBEANS(UniversityId).ToList<ApplicationBEAN>();
    }

    [WebMethod]
    public List<ApplicationBEAN> GetApplicationsByCourse(int UniversityId, String CourseName)
    {
        return _applicationService.GetUniversityApplicationBEANSByCourseName(UniversityId, CourseName).ToList<ApplicationBEAN>();
    }

    [WebMethod]
    public String MakeApplicationOffer(int ApplicationId, int UniversityId, string Offer)
    {
        if (Offer != "C" && Offer != "U" && Offer != "R") return "Offer not allowed.";
        Application application = _applicationService.GetApplication(ApplicationId);
        if (application.Firm == true) return "The application is already confirmed.";
        if (application.UniversityId != UniversityId) return "Not allowed to make offer.";
        if (application.UniversityOffer == "R") return "The application is already rejected.";
        if (application.UniversityOffer == "U") return "The application is already on unconditional.";

        _applicationService.MakeApplicationOffer(ApplicationId, Offer);
        return "Success!";
    }
    
}
