using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseBetting2020.Business
{
    static class Factory
    {
        //Decides which Punter to instantiate
        public static Punter GetAPunter(int id)
        {
            switch (id)
            {
                case 0:
                    return new Declan();
                case 1:
                    return new Gerard();
                case 2:
                    return new Alien();

                default: return null;
            }
        }
    }
}
