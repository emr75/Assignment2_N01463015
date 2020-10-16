using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class J1Controller : ApiController
    {

        /// <summary>
        /// Recieves 4 integer inputs representing the type of 
        /// burger, drink, side, and dessert selected and returns 
        /// the total amount of calories of the meal
        /// </summary>
        /// <param name="burger">An integer representing the type of burger selected</param>
        /// <param name="drink">An integer representing the type of drink selected</param>
        /// <param name="side">An integer representing the type of side selected</param>
        /// <param name="dessert">An integer representing the type of dessert selected</param>
        /// <example>GET /api/J1/Menu/4/4/4/4     -> Your total calorie count is 0</example>
        /// <example>GET /api/J1/Menu/1/2/3/4     -> Your total calorie count is 691</example>
        /// <returns>The total amount of calories for the selected meal</returns>
        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public string Menu(int burger, int drink, int side, int dessert)
        {
            //burgerchoice represents the chosen burger type and it's subsequent calories
            int burgerchoice;
            if (burger == 1) burgerchoice = 461;
            else if (burger == 2) burgerchoice = 431;
            else if (burger == 3) burgerchoice = 420;
            else burgerchoice = 0;

            //drinkchoice represents the chosen drink type and it's subsequent calories
            int drinkchoice;
            if (drink == 1) drinkchoice = 130;
            else if (drink == 2) drinkchoice = 160;
            else if (drink == 3) drinkchoice = 118;
            else drinkchoice = 0;

            //sidechoice represents the chosen side type and it's subsequent calories
            int sidechoice;
            if (side == 1) sidechoice = 100;
            else if (side == 2) sidechoice = 57;
            else if (side == 3) sidechoice = 70;
            else sidechoice = 0;

            //dessertchoice represents the chosen dessert type and it's subsequent calories
            int dessertchoice;
            if (dessert == 1) dessertchoice = 167;
            else if (dessert == 2) dessertchoice = 266;
            else if (dessert == 3) dessertchoice = 75;
            else dessertchoice = 0;

            //totalcal represents the sum of all four selected items' calories
            int totalcal = burgerchoice + drinkchoice + sidechoice + dessertchoice;
            //result
            return "Your total calorie count is " + totalcal;
        }
    }
}
