using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using dev.Solver.Colculation;
using dev.Solver.WebInterface.Calculation;


namespace dev.Solver.WebInterface
{
    /// <summary>
    /// Summary description for MyApiWCFService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class MyApiWCFService : System.Web.Services.WebService
    {

        [WebMethod]
        public string GetResult(string input)
        {
            CalculationWCFServiceSoapClient client = new CalculationWCFServiceSoapClient();
            var result = client.HelloWorld(input);
            return result;
        }
    }
}
