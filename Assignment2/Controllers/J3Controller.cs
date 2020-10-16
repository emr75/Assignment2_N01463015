using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class J3Controller : ApiController
    {
        /// <summary>
        /// Recieves two integers inputs representing size of room
        /// and outputs a true or false statement
        /// to determine if it is possible to escape.
        /// </summary>
        /// <param name="m">An integer representing the numbber of rows</param>
        /// <param name="n">An integer representing the numbber of columns</param>
        /// <returns>A true or false statement on the ability to escape based on the dimensions of the room</returns>
        [Route("api/J3/EscapeGame/{a}/{b}")]
        public bool GetEscapeGame(int a, int b)
        {
            bool mrows = 1 <= a <= 1000;
            bool nrows = 1 <= b <= 1000;

            int cell = 0;
            for (bool mrows = 1; m <= 2; m++)

                return true;
        }
    }
}
