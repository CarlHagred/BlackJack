using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesLib.DB
{
    public class PlayerRound
    {
        public int Id { get; set; }
        public string playerName { get; set; }
        public int score { get; set; }
        public int gameID { get; set; }
    }
}
