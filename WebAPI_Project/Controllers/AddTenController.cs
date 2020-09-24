using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI_Project.Controllers
{
    public class AddTenController : ApiController
    {
        // Get api/AddTen/{id}
        public int Get(int id)
        {
            return id + 10;
        }
        
        
    }
}
