using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI_Project.Controllers
{
    public class LoopsController : ApiController
    {
        /// <summary>
        /// Challenge 1
        /// Print 1 to 25 counting by 1s
        /// <example>GET api/Loops/C1While</example>
        /// </summary>
        /// <returns>string 1 to 25 separated by ","</returns>
        [HttpGet]
        public string C1While()
        {
            //declare variable
            int i = 1;
            string msg = "";
            while (i<=25)
            {
                //adding i to the msg
                msg = msg + i.ToString() + ",";
                //incrementing our iterating value
                i = i + 1;
                    
            }
            //display message on the screen
            return msg;
        }

        /// <summary>
        /// Challenge 1
        /// Print -10 to 10 counting by 1s
        /// <example>GET api/Loops/C2While</example>
        /// </summary>
        /// <returns>string -10 to 10 separated by ","</returns>
        [HttpGet]
        [Route("api/Loops/{C2While}")]
        public string C2While()
        {
            //declare variable
            int i = -10;
            string msg = "";
            while (i <= 10)
            {
                //adding i to the msg
                msg = msg + i.ToString() + ",";
                //incrementing our iterating value
                i = i + 1;

            }
            //display message on the screen
            return msg;
        }

        /// <summary>
        /// Challenge 1
        /// Print -20 to -10 counting by 2s
        /// <example>GET api/Loops/C3While</example>
        /// </summary>
        /// <returns>string -20 to -10 separated by ","</returns>
        [HttpGet]
        [Route("api/Loops/C3While")]
        public string C3While()
        {
            //declare variable
            int i = -20;
            string msg = "";
            while (i <= -10)
            {
                //adding i to the msg
                msg = msg + i.ToString() + ",";
                //incrementing our iterating value
                i = i + 2;

            }
            //display message on the screen
            return msg;
        }

        /// <summary>
        /// Challenge 1
        /// Print -30 to 30 counting by 4s
        /// <example>GET api/Loops/C4While</example>
        /// </summary>
        /// <returns>string -30 to 30 separated by ","</returns>
        [HttpGet]
        [Route("api/Loops/C4While")]
        public string C4While()
        {
            //declare variable
            int i = -30;
            string msg = "";
            while (i <= 30)
            {
                //adding i to the msg
                msg = msg + i.ToString() + ",";
                //incrementing our iterating value
                i = i + 4;

            }
            //display message on the screen
            return msg;
        }

     





        /// <summary>
        /// Challenge 2
        /// Print 1 to 25 counting by 1s by using for loop
        /// </summary>
        /// <exmple>
        /// GET api/Loops/C1For
        /// </exmple>
        /// <returns>string 1 to 25 separated by ","</returns>
        [HttpGet]
      
        public string C1For()
        {
            int i;
            string msg = "";
            for (i = 1; i<=25; i++)
            {
                msg = msg + i.ToString() + ",";
            }
            return msg;
        }

        /// <summary>
        /// Challenge 2
        /// Print -10 to 10 counting by 1s by using for loop
        /// </summary>
        /// <exmple>
        /// GET api/Loops/C2For
        /// </exmple>
        /// <returns>string 1 to 25 separated by ","</returns>
        [HttpGet]
        [Route("api/Loops/{C2For}")]

        public string C2For()
        {
            int i;
            string msg = "";
            for (i = -10; i <= 10; i++)
            {
                msg = msg + i.ToString() + ",";
            }
            return msg;
        }






    }
}




 
