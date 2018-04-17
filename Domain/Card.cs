using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Domain
{
    public class Card 
    {
        private CardSuit suit;
        private CardRank rank;
         
        public Card(CardSuit s, CardRank r) {
            suit = s;
            rank = r;
        }

        public CardRank Rank { get => rank; set => this.rank = value; }
        public CardSuit Suit { get => suit; set => suit = value; }

        
        public int CompareTo(Card other){
            return (this.rank.CompareTo(other.rank));
        }

        public int CompareSuit(Card other){
            return (this.suit.CompareTo(other.suit));
        }

        public enum CardRank {
            two = 2,
            three,
            four,
            five,
            six,
            seven,
            eight,
            nine,
            ten,
            jack,
            queen,
            king,
            ace
        }

        public enum CardSuit{
            hearts,
            diamonds,
            clubs,
            spades
        }


   
    }
}
