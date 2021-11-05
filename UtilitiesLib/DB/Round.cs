using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesLib.DB
{
    public class Round
    {
        public int Id { get; set; }
        public int gameID { get; set; }
        public int amountOfPlayers { get; set; }
        public int highestScore { get; set; }
    }
}
