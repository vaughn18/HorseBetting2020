using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseBetting2020.Business
{
    class Alien:Punter
    {
        public Alien()
        {
            PunterName = "Alien of the Unknown";
            Racer = "";
            Bet = 0;
            Cash = 800;
        }
    }
}
