using System;
using System.Windows.Forms;

namespace HorseBetting2020.Business
{
    public class Punter
    {
        public string PunterName { get; set; }
        public string Racer { get; set; }
        public Single Cash { get; set; }
        public Single Bet { get; set; }
        public Label LabelWinner { get; set; }

    }
}
