using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Domain
{
    public class CardDeck
    {
        private List<Card> cards; 
        private Random rd; 

        public CardDeck(List<Card> c, Random ran) {
            cards = c;
            rd = ran;
            fillDeck();
        }
        public void fillDeck() {
            cards.Clear();
            foreach (Card.CardRank r in Enum.GetValues(typeof(Card.CardRank))) {
                foreach (Card.CardSuit s in Enum.GetValues(typeof(Card.CardSuit))) {
                    cards.Add(new Card(s, r));
                }
            }
        }
        public Card getRandomCard() {
            int index = rd.Next(0, cards.Count);
            Card returnCard = cards[index];
            cards.RemoveAt(index);
            return returnCard;
        }
    }
}
