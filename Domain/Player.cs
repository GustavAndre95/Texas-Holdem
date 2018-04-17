using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Domain
{
    public abstract class Player
    {
        private Boolean hasBetted;
        public Boolean HasBetted { get => hasBetted; set => hasBetted = value; }

        private int totalBet;
        public int TotalBet { get => totalBet; set => totalBet = value; }

        private Boolean hasFolded;
        public Boolean HasFolded { get => hasFolded; set => hasFolded = value; } 
        private Boolean hasBettedAll;
        public Boolean HasBettedAll { get => hasBettedAll; set => hasBettedAll = value; }

        private String name;
        public String Name { get => name; set => name = value; }
        
        private int cash;
        public int Cash { get => cash; set => cash = value; }
      
        protected GameTable gameBoard;

        private List<Card> pocketCards;
        public List<Card> PocketCards { get => pocketCards; set => pocketCards = value; }

        private CardHand bestCards;
        public CardHand BestCards { get => bestCards; set => bestCards = value; }

        public Player(String n, int c, GameTable gameBoard) {
            name = n;
            cash = c;
            hasBetted = false;
            hasFolded = false;
            this.gameBoard = gameBoard;
            this.pocketCards = new List<Card>();
        }

        //This function should only be called WHEN IT IS ALLOWED. Other functions must check if the bet is reasonable and follows the rules.
        public void bet(int betSum) {
            totalBet += betSum;
            if (totalBet>gameBoard.MinimumBet){
                gameBoard.MinimumBet += totalBet - gameBoard.MinimumBet;
                 Console.WriteLine(name + " raises the minimum bet to " + gameBoard.MinimumBet);
             }
            cash -=betSum;    
            gameBoard.CurrentPot += betSum;
            Console.WriteLine(name + " betted " + betSum +".");
            Console.WriteLine(name + "'s cash is now " + cash + " and the pot is " + gameBoard.CurrentPot);
            hasBetted = true;
        }

        public void fold(){
            hasFolded = true;
            Console.WriteLine(name + " has now folded and is skipping the rest of the session.");
        }

        public void showCards(){
            Console.Write(Name + " has the cards");
            foreach (Card c in pocketCards) { 
                Console.Write(": " + c.Rank + " of " + c.Suit);
            Console.WriteLine();
            }
        }

        public void giveBlind(){
            int blindvalue = gameBoard.BlindValue;
           
            if (blindvalue > cash) {
               blindvalue = cash;    
            } 
            gameBoard.CurrentPot +=blindvalue;
            cash -= blindvalue;
            Console.WriteLine(name + " has blinded 5," + " the pot is now " + gameBoard.CurrentPot);
        }

        public void playHand()
        {
            if (hasFolded || hasBettedAll) {
                Console.WriteLine(name + " is not playing his hand this round...");
            }   else { 
                         if (hasBetted) {
                               if (totalBet==gameBoard.MinimumBet){ 
                                    return;
                               }
                         }
                            Console.WriteLine(name + " is making his decision...");
                            makeDecision();
                }    
        }
        public abstract void makeDecision();
    }
}