using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI_Project.Controllers
{
    public class HostingFNController : ApiController
    {
        //Get api/HostingFN/{id}
        public IEnumerable<string> Get(int id)
        {
            double fortnights = id / 14;
            double fortnightPrice = (fortnights + 1) * 5.50;
            double HST = (fortnightPrice * 13) / 100;
            double totalcost = fortnightPrice + HST;
            string txt1 = fortnights + " " + "fortnights at $5.50/FN = $" + fortnightPrice.ToString("0.00") + " " + "CAD";
            string txt2 = "HST 13% = $" +Math.Round(HST,2) + " " + "CAD";
            string txt3 = "Total = $" + Math.Round(totalcost,2) + " " + "CAD";
            return new string[] { txt1, txt2, txt3 };
        }

    }
}