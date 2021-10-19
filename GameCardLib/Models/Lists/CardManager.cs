using System;

namespace GameCardLib.Models.Lists
{
    [Serializable]
    public class CardManager<Card> : ListManager<Card>
    {
        public CardManager() : base()
        {
        }
    }
}
