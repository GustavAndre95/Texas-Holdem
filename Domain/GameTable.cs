using ConsoleApp1.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Domain
{
    public class GameTable : JudgeInterface
    {
        
        private ResultAnalyzer analyzer;
        private CardDeck cd;
        private List<Card> cardsShown;
        public List<Card> CardsShown {get => cardsShown; set => cardsShown = value; }
        public GameTable(CardDeck cd, ResultAnalyzer ra){
            this.cd = cd;
            analyzer = ra;
            blindValue = 5; //Keeping this 5 for now
            cardsShown = new List<Card>();
            players = new List<Player>();
            roundIndex = 0;
          
            }

        private int roundIndex;
        public int RoundIndex{ get => roundIndex; set => roundIndex = value; }
        private int blindValue;
        public int BlindValue { get => blindValue; set => blindValue = value; }
        private int minimumBet;
        public int MinimumBet { get => minimumBet; set => minimumBet = value; }

        private int currentPot;
        public int CurrentPot { get => currentPot; set => currentPot = value; }
       
        private List<Player> players;
        public List<Player> Players { get => players; set => players = value; }

        public void layCards()  {
            if (cardsShown.Count == 0) {
                for (int i = 0; i<3; i++) {
                   cardsShown.Add(cd.getRandomCard());
                 }
            }
            else if (cardsShown.Count== 3 || cardsShown.Count==4) {
                        cardsShown.Add(cd.getRandomCard());
            }
            Console.WriteLine();
            Console.WriteLine("New cards has been laid out on the table. The cards are:");
            foreach (Card c in cardsShown) {
                Console.WriteLine(c.Suit + " " + c.Rank);
            }
                Console.WriteLine();
        }

        public void dealCards(){
            Console.WriteLine("Cards are being dealt out...");
            cd.fillDeck(); //The carddeck is reshuffled.
            foreach (Player p in players) {
                p.PocketCards.Clear(); //Players cards are being cleared.
                p.PocketCards.Add(cd.getRandomCard());
                p.PocketCards.Add(cd.getRandomCard());         
            }
         }

        public Player decideWinner(){
            List<Player> toDecide = new List<Player>();
            Console.WriteLine();
            Console.WriteLine("Time for the showdown!");
                     
            foreach (Player p in players) {
                if (!p.HasFolded){
                    toDecide.Add(p);
                    analyzer.calculateResults(p, cardsShown);
                }            
                    
            }
                toDecide = analyzer.sortPlayers(toDecide);
                Player winner = toDecide[0];
                winner.Cash += CurrentPot;
                currentPot = 0;
                return toDecide[0];
        }
    }
}
