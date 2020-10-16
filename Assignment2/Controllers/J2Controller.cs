using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class J2Controller : ApiController
    {

        /// <summary>
        /// Recieves two integer inputs representing the amount of sides 
        /// on a dice and returns an integer of how many times the 
        /// sum of ten can be rolled
        /// </summary>
        /// <param name="m">The input representing an m sided die</param>
        /// <param name="n">The input representing an n sided die</param>
        /// <example>GET /api/J2/DiceGame/6/8     -> There are 5 ways to get the sum 10</example>
        /// <example>GET /api/J2/DiceGame/12/4    -> There are 4 ways to get the sum 10</example>
        /// <returns>The number of times the sum of 10 can be rolled</returns>
        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]
        public string DiceGame(int m, int n)
        {
            //tentotal represents the amount of combinations that have a sum of ten
            int tentotal = 0;

            //for loop counting up by 1 to the amount of sides on the m die
            for (int i = 1; i <= m; i++)
            {
                //for loop counting down by 1 to the amount of sides on the n die
                for (int j = n; j >= 1; j--)
                {
                    //if statement determining when a side of the m die (i) and the n die (j) have a sum of 10
                    if (i + j == 10)
                    {
                        tentotal = tentotal + 1;
                    }
                }
            }
            return "There are " + tentotal + " total ways to get the sum 10";
        }
    }
}
