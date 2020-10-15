using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI_Project.Controllers
{
    public class ExampleController : ApiController
    {
        /// <summary>
        /// GET api/Example/GethalfUp/{id}
        /// </summary>
        /// <param name="id">The input Number</param>
        /// <returns>Half of the input number(rounded up)</returns>
        [Route("api/Example/GethalfUp/{id}")]
        public int GethalfUp(int id)
        {
            decimal quotient = (decimal)id / 2;
            quotient = Math.Ceiling(quotient);
            return (int)(quotient);
        }


        /// <summary>
        /// GET api/Example/GethalfDown/{id}
        /// </summary>
        /// <param name="id">The input Number</param>
        /// <returns>Half of the input number(rounded down)</returns>
        [Route("api/Example/GethalfDown/{id}")]
        public int GethalfDown(int id)
        {
            decimal quotient = (decimal)id / 2;
            quotient = Math.Floor(quotient);
            return (int)(quotient);
        }


        /// <summary>
        /// calculate the product of two integers
        /// </summary>
        /// <param name="factor1">First integer factor</param>
        /// <param name="factor2">Second integer factor</param>
        /// <returns>The product of two integer factors</returns>
        /// /// <example>
        /// GET: api/Example/product/30/2
        /// </example>
        /// <example>
        ///  GET: api/Example/product/-10/1
        /// </example>
        [Route("api/Example/product/{factor1}/{factor2}")]
        public int Getproduct(int factor1, int factor2)
        {
            return factor1 * factor2;
        }

        /// <summary>
        /// find the number of characters in the string
        /// </summary>
        /// <param name="message">The input string</param>
        /// <example>
        /// GET: api/Example/Strlen/hello
        /// </example>
        /// <example>
        /// GET: api/Example/Strlen/goodbye
        /// </example>
        /// <returns>The number of characters in the string</returns>
        [Route("api/Example/Strlen/{message}")]
        public int GetStrlen(string message)
        {
            return message.Length;
        }

        /// <summary>
        /// Receive an input as temprature and provide a message indicating the different seasons
        /// Get api/Example/Season/{temperature}
        /// </summary>
        /// <example>
        /// Get api/Example/Season/21 -->"The season is Summer!"
        /// </example>
        /// <example>
        /// Get api/Example/Season/17 -->"The season is Fallr!"
        /// </example>
        /// <example>
        /// Get api/Example/Season/-15 -->"The season is Winter!"
        /// </example>
        /// <param name="temperature"></param>
        /// <returns></returns>
        [Route("api/Example/Season/{temperature}")]
        public string GetSeason(int temperature)
        {
            string season = "";
            if(temperature > 20)
            {
                season = "Summer";
            } else if(temperature > 15)
            {
                season = "Fall";
            } else if(temperature >10)
            {
                season = "Spring";
            }
            else
            {
                season = "Winter";
            }
            string message = "The season is " + season + "!";
            return message;
        }
    }
}

    

