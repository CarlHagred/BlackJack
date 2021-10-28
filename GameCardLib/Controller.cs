using GameCardLib.Models;
using GameCardLib.Models.Lists;
using System.Linq;
using BlackJack;

namespace GameCardLib
{
    public class Controller
    {
        public DeckManager<Deck> AmonutOfDecks(int amountOfDecks){
            DeckManager<Deck> deckList = new DeckManager<Deck>();

            foreach (int i in Enumerable.Range(0, amountOfDecks)) deckList.Add(new Deck());
            
            return deckList;
        }

        public PlayerManager<Player> AmountOfPlayers(int amountOfPlayers){
            PlayerManager<Player> playersList = new PlayerManager<Player>();
            
            for(int i = 0; i < amountOfPlayers; i++)
            {
                /*playersList.Add(new Player {
                    PlayerID = ,
                    Name = ,
                    Hand = ,
                });*/
            }
            return playersList;
        }
    }   
}
