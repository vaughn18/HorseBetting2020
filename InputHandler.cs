using HorseBetting2020.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseBetting2020
{
    class InputHandler
    {
        string[] racersList = {"Sonic", "Minato", "Monkey", "Counter-Terrorist"};
        //checks if there is a punter selected
        public string isBetSuccess(string punter, decimal betPlaced, string racer, decimal wallet)
        {
            if(punter == String.Empty)
            {
                return "Please select a punter";
            }else if(betPlaced <= 0 && wallet >= 0 )
            {
                return "Please place a bet for the Punter chosen";
            }else if(racer == String.Empty)
            {
                  return "Please select a Racer for the Punter";
            }else if(!racersList.Contains(racer))
            {
                return "The Racer you have chosen is not listed to compete";
            }else
            {
                return null;
            }
        }
    }
}
