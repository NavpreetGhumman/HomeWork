using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI_Project.Controllers
{
    public class IfPracticIeController : ApiController
    {
        //
        /// <summary>
        /// Get api/IfPractice/CoinComputer/{a}/{b}/{c}/{d}/{e}
        /// </summary>
        /// <param name="a">First input</param>
        /// <param name="b">Second Input</param>
        /// <param name="c">Third Input</param>
        /// <param name="d">Forth Input</param>
        /// <param name="e">Fifth Inpt</param>
        /// <returns>return true if total is more than 10.50 otherwise false</returns>
        [Route("api/IfPractice/CoinComputer/{a}/{b}/{c}/{d}/{e}")]
        [HttpGet]
        public bool CoinComputer(int a, int b, int c, int d, int e)
        {
            double nickles = a * 0.05;
            double dimes = b * 0.10;
            double quarters = c * 0.25;
            double loonies = d * 1.00;
            double twoonies = e * 2.00;

            decimal nickles1 = (decimal)nickles;
            decimal dimes1 = (decimal)dimes;
            decimal quarters1 = (decimal)quarters;
            decimal loonies1 = (decimal)loonies;
            decimal twoonies1 = (decimal)twoonies;

            decimal total = nickles1 + dimes1 + quarters1 + loonies1 + twoonies1;
            int total1 = (int)total;

            if (total1 >= 10.50) return true;
            else return false;
        }


        //
        /// <summary>
        /// Get api/IfPractice/PointQuadrant/{x}/{y}
        /// </summary>
        /// <param name="x">first input</param>
        /// <param name="y">second input</param>
        /// <returns>return location of the point (x,y)</returns>
        [HttpGet]
        [Route("api/IfPractice/PointQuadrant/{x}/{y}")]
        public int PointQuadrant(int x, int y)
        {
            if(x > 0 && y > 0) return 1;
            else if (x < 0 && y > 0) return 2;
            else if (x > 0 && y < 0) return 3;
            else if (x < 0 && y < 0) return 4;
            else return 0;
         }
    }
}
