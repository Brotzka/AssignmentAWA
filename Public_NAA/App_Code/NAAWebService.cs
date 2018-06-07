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
    public List<ApplicationBEAN> GetAllApplications(int Id)
    {
        return _applicationService.GetUniversityApplicationBEANS(Id).ToList<ApplicationBEAN>();
    }

    [WebMethod]
    public String MakeApplicationOffer(int Id, string Offer)
    {
        _applicationService.MakeApplicationOffer(Id, Offer);
        return "Success!";
    }
}
