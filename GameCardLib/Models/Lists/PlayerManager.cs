using System;

namespace GameCardLib.Models.Lists
{
    [Serializable]
    public class PlayerManager<Player> : ListManager<Player>
    {
        public PlayerManager() : base()
        {
        }
    }
}