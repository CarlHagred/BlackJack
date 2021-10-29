using GameCardLib.Models;
using GameCardLib.Models.Lists;
using System.Linq;
using System;
using System.Diagnostics;

namespace GameCardLib
{
    public class Controller
    {
        /*
        public event Action NewGameEvent;
        public event Action ShuffleEvent;
        public event Func<Dictionary<string, string>> HitEvent;
        public event Func<int, bool> StandEvent;
        public event Func<bool> NoPlayerLeftEvent;
        public event Func<bool> NextPlayerEvent;
        public event Func<bool> NewRoundEvent;
        */
        PlayerManager<Player> playersList = new PlayerManager<Player>();
        Deck deck;

        public void NewGame(int amountOfPlayers, int amountOfCards)
        {
            //reset players och dealer om det finns ett game innan
            //osäker på om det behövs en lista här eller om det kan skippas då alla deck kommer se likadana ut
            for(int i=0; i < amountOfPlayers; i++)
            {
                Player player = new Player();
                player.Name = "Player: " + i.ToString();
                playersList.Add(player);
            }

            deck = new Deck(amountOfCards);
           
        }





        /*
        public Card DrawCardToHand(CardHand hand)
        {
            int sumOfCards = 0;
            Card drawn = listOfCards[listOfCards.Count - 1];
            hand.AddCardValues(drawn, sumOfCards);
            listOfCards.Remove(drawn);
            hand.Cards.Add(drawn);
            //Debug.WriteLine(drawn.Value);
            return drawn;
        }
        */

        public void DrawCard(){
            //Behöver få value och suit från enum
            //Kortet ska läggas till i spelarens hand
            //Kortet behöver tas bort från deck

           
        }

        public void Stand(Player player, Hand hand){
            //om spelaren > 21 ska han DÖ
            //Jämföra poäng med dealern
            //Korten tillbaka till deck??
        }

        public void ShuffleDeck(Deck deck){
            
        }
    }
}
