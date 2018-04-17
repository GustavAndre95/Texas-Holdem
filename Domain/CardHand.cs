using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Domain
{
    public class CardHand
    {
        private List<Card> cards;
        public List<Card> Cards { get => cards; set => cards = value; }
        private HandRank type;
        public HandRank Type { get => type; set => type = value; }

        public CardHand(List<Card> cards, HandRank type)
        {
            this.cards = cards;
            this.type = type;
        }

        public enum HandRank
        {
            HighCard,
            Pair,
            TwoPair,
            ThreeOfAKind,
            Straight,
            Flush,
            FullHouse,
            FourOfAKind,
            StraightFlush,
            RoyalFlush
        }

    }
}
