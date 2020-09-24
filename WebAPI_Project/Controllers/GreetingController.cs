using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI_Project.Controllers
{
    public class GreetingController : ApiController
    {
        //GET api/Greeting/{id}
        /// <summary>
        /// returns the greeting message
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string Get(int id)
        {
            string msg1 = "Greetings to ";
            string msg2 = " people!";
            return msg1 + id + msg2;
        }
        //Post api/Greeting
        public string Post()
        {
            return "Hello World!";
          
        }

    }
}
