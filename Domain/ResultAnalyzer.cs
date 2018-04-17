using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ConsoleApp1.Domain
{
    public class ResultAnalyzer
    {
        private const int CompareableCards = 5;

        public void calculateResults(Player player, List<Card> cardsShown) {
            //All card available for combination
            
            var allcards = new List<Card>();
            foreach (Card c in cardsShown){
                allcards.Add(c);
            }
            foreach (Card c in player.PocketCards){
                allcards.Add(c);
            }
            allcards = sortCards(allcards);
            Console.WriteLine("Checking hands for player " +  player.Name);
            player.BestCards = determineHand(allcards);
            player.BestCards.Cards = sortCards(player.BestCards.Cards);
               
            //--------------------------------
            //TEST CASE CARD DECKS
            //--------------------------------
            /*
            List<Card> testDeck = new List<Card>();
            testDeck.Add(new Card(Card.CardSuit.Hearts, Card.CardRank.Ace));
            testDeck.Add(new Card(Card.CardSuit.Hearts, Card.CardRank.King));
            testDeck.Add(new Card(Card.CardSuit.Hearts, Card.CardRank.Queen));
            testDeck.Add(new Card(Card.CardSuit.Clubs, Card.CardRank.Ace));
            testDeck.Add(new Card(Card.CardSuit.Spades, Card.CardRank.Nine));
            testDeck.Add(new Card(Card.CardSuit.Hearts, Card.CardRank.Ace));
            testDeck.Add(new Card(Card.CardSuit.Hearts, Card.CardRank.Four));
            //Sort cards by highest value first
            testDeck = sortCards(testDeck);
            CardHand hand = determineHand(testDeck);
            if (hand != null){
                Console.WriteLine(hand.Type);
                foreach (Card c in hand.Cards)
                    Console.WriteLine(c.Rank + " of " + c.Suit);
            }*/
        }

        public List<Player> compareResults(List<Player> players){
            //Compares players result, returns list with winner (or winners if splitpot)
            return null;
        }

        public CardHand determineHand(List<Card> cards){
            if (isRoyalFlush(cards) != null) {
                return isRoyalFlush(cards);
            } else if (isStraightFlush(cards) != null) {
                return isStraightFlush(cards);
            } else if (isFourOfAKind(cards) != null) {
                return isFourOfAKind(cards);
            } else if (isFullHouse(cards) != null) {
                return isFullHouse(cards);
            } else if (isFlush(cards) != null) {
                return isFlush(cards);
            } else if (isStraight(cards) != null) {
                return isStraight(cards);
            } else if (isThreeOfAKind(cards) != null) {
                return isThreeOfAKind(cards);
            } else if (isTwoPair(cards) != null) {
                return isTwoPair(cards);
            } else if (isPair(cards) != null) {
                return isPair(cards);
            } else {
                return getHighestCards(cards);
            }
        }

        public CardHand isRoyalFlush(List<Card> cards) {
            Console.WriteLine("Checking for royalflush...");
            CardHand hand = isStraightFlush(cards);
            if (hand != null) {
                bool aceExists = false, kingExists = false, queenExists = false, jackExists = false, tenExists = false;
                foreach (Card c in cards) {
                    switch (c.Rank) {
                        case Card.CardRank.ace:
                            aceExists = true;
                            break;
                        case Card.CardRank.king:
                            kingExists = true;
                            break;
                        case Card.CardRank.queen:
                            queenExists = true;
                            break;
                        case Card.CardRank.jack:
                            jackExists = true;
                            break;
                        case Card.CardRank.ten:
                            tenExists = true;
                            break;
                    }
                }
                if (aceExists && kingExists && queenExists && jackExists && tenExists){
                    hand.Type = CardHand.HandRank.RoyalFlush;
                    return hand;
                }
                return null;
            } else {
                return null;
            }
        }

        public CardHand isStraightFlush(List<Card> cards){
            Console.WriteLine("Checking for straightflush...");
            CardHand hand = isFlush(cards);
            if (hand != null)
                hand = isStraight(hand.Cards);
            if (hand != null)
                hand.Type = CardHand.HandRank.StraightFlush;
            return hand;
        }

        public CardHand isFourOfAKind(List<Card> cards){
            Console.WriteLine("Checking for fourofakind...");
            List<Card> fours = new List<Card>();
            for (int i = 0; i < cards.Count; i++){
                for (int k = i+1; k < cards.Count; k++) {
                    if (cards[i].CompareTo(cards[k]) == 0) {
                        if (!fours.Contains(cards[i]))
                            fours.Add(cards[i]);
                        if (!fours.Contains(cards[k]))
                            fours.Add(cards[k]);
                        if (fours.Count == 4) {
                            CardHand hand = new CardHand(fours, CardHand.HandRank.FourOfAKind);
                            return fillHighestCards(cards, hand);
                        }
                    }
                }
                fours.Clear();
            }
            return null;
        }

        public CardHand isFullHouse(List<Card> cards){
            Console.WriteLine("Checking for fullHouse...");
            List<Card> fullhouse = new List<Card>();
            List<Card> pair = new List<Card>();
            for (int i = 0; i < cards.Count; i++){
                for (int k = i+1; k < cards.Count; k++){
                    if (cards[i].CompareTo(cards[k]) == 0){
                        if (!fullhouse.Contains(cards[i]))
                            fullhouse.Add(cards[i]);
                        if (!fullhouse.Contains(cards[k]))
                            fullhouse.Add(cards[k]);
                        if((fullhouse.Count + pair.Count) == 5){
                            fullhouse.AddRange(pair);
                            fullhouse = sortCards(fullhouse);
                            return new CardHand(fullhouse, CardHand.HandRank.FullHouse);
                        }
                    }
                }
                if(fullhouse.Count < 3 && pair.Count < fullhouse.Count){
                    foreach (Card c in fullhouse)
                        pair.Add(c);
                    fullhouse.Clear();
                }
            }
            return null;
        }

        public CardHand isFlush(List<Card> cards){
            Console.WriteLine("Checking for flush...");
            List<Card> hand;
            int noOfClubs = 0;
            int noOfSpades = 0;
            int noOfHearts = 0;
            int noOfDiamonds = 0;
            foreach (Card c in cards) {
                switch (c.Suit) {
                    case Card.CardSuit.hearts:
                        noOfHearts++;
                        break;
                    case Card.CardSuit.spades:
                        noOfSpades++;
                        break;
                    case Card.CardSuit.clubs:
                        noOfClubs++;
                        break;
                    case Card.CardSuit.diamonds:
                        noOfDiamonds++;
                        break;
                }
            }
            if(noOfHearts >= 5){
                hand = getFlushCards(Card.CardSuit.hearts, cards);
            } else if (noOfSpades >= 5){
                hand = getFlushCards(Card.CardSuit.spades, cards);
            } else if (noOfClubs >= 5){
                hand = getFlushCards(Card.CardSuit.clubs, cards);
            } else if (noOfDiamonds >= 5){
                hand = getFlushCards(Card.CardSuit.diamonds, cards);
            } else {
                return null;
            }
            return new CardHand(hand, CardHand.HandRank.Flush);
            }

        public CardHand isStraight(List<Card> cards){
            Console.WriteLine("Checking for straight...");
            List<Card> hand = new List<Card>();
            int pos = 0;
            int cardsleft = cards.Count;
            while (pos < cardsleft - 1) {
                if (cards[pos].Rank.CompareTo(cards[pos + 1].Rank) == 0){
                    pos++;
                    continue; //In case the next card has the same value
                }
                    if (cards[pos].Rank - cards[pos+1].Rank ==-1){
                        hand.Add(cards[pos]);
                        if (hand.Count == 4) {
                        hand.Add(cards[pos+1]);
                        return new CardHand(hand, CardHand.HandRank.Straight);
                        } else {
                        pos++;
                        }
                    } 
                    else {
                        cardsleft = hand.Count;
                        hand.Clear();
                        pos++;
                    }   
            }
            return null;
        }

        public CardHand isThreeOfAKind(List<Card> cards){
            Console.WriteLine("Checking for threeofakind...");
            List<Card> threes = new List<Card>();
             for (int i = 0; i < cards.Count; i++){
                for (int k = i+1; k < cards.Count; k++) {
                    if (cards[i].CompareTo(cards[k]) == 0) {
                        if (!threes.Contains(cards[i]))
                            threes.Add(cards[i]);
                        if (!threes.Contains(cards[k]))
                            threes.Add(cards[k]);
                        if (threes.Count == 3) {
                            CardHand hand = new CardHand(threes, CardHand.HandRank.ThreeOfAKind);
                            return fillHighestCards(cards, hand);
                        }
                    }
                }
                threes.Clear();
            }
            return null;
        }

        public CardHand isTwoPair(List<Card> cards){
            Console.WriteLine("Checking for twopair...");
            List<Card> pairs = new List<Card>();
            for (int i = 0; i < cards.Count; i++){
                for (int k = i+1; k < cards.Count; k++) {
                    if (cards[i].CompareTo(cards[k]) == 0) {
                        pairs.Add(cards[i]);
                        pairs.Add(cards[k]);
                        if (pairs.Count == 4) {
                            CardHand hand = new CardHand(pairs, CardHand.HandRank.TwoPair);
                            return fillHighestCards(cards, hand);
                        }
                    }
                }
            }
            return null;
        }
        
        public CardHand isPair(List<Card> cards){
            Console.WriteLine("Checking for pair...");
            List<Card> pair = new List<Card>();
            for (int i = 0; i < cards.Count; i++){
                for (int k = i+1; k < cards.Count; k++) {
                    if (cards[i].CompareTo(cards[k]) == 0) {
                        pair.Add(cards[i]);
                        pair.Add(cards[k]);
                        CardHand hand = new CardHand(pair, CardHand.HandRank.Pair);
                        return fillHighestCards(cards, hand);
                    }
                }
            }
            return null;
        }   

        public CardHand getHighestCards(List<Card> cards){
            Console.WriteLine("Checking for highestcardal...");
            List<Card> list = new List<Card>();
            for (int i = 0; list.Count < CompareableCards && i < cards.Count; i++){
                if (!list.Contains(cards[i]))
                    list.Add(cards[i]);
            }
            CardHand hand = new CardHand(list, CardHand.HandRank.HighCard);
            hand.Cards = sortCards(hand.Cards);
            return hand;
        }

        public CardHand fillHighestCards(List<Card> cards, CardHand hand){
            for (int i = 0; hand.Cards.Count < CompareableCards && i < cards.Count; i++){
                if (!hand.Cards.Contains(cards[i]))
                    hand.Cards.Add(cards[i]);
            }
            //If don't sort the hand here, I can easily check which player has the highest
            //card if they have the same handType. Simply check the firstcard of each player 
            //and see which has the one of highest value.
            //hand.Cards = sortCards(hand.Cards);
            return hand;
        }

        public List<Card> getFlushCards(Card.CardSuit suit, List<Card> cards){
            List<Card> flushcards = new List<Card>();
            foreach(Card c in cards){
                if(flushcards.Count >= CompareableCards)
                    return flushcards;
                if (c.Suit == suit)                   
                    flushcards.Add(c);
            }
            return flushcards;
        }

        public List<Card> sortCards(List<Card> cards){
            return cards.OrderByDescending(x => x.Rank).ToList();
        }

        public List<Player> sortPlayers(List<Player> players){
            List <Player> playerStats = players.OrderByDescending(x => x.BestCards.Type).ToList();

            if (playerStats.Count == 1)
                return playerStats;

            if (playerStats[0].BestCards.Type.CompareTo(playerStats[1].BestCards.Type) == 0) {  //This code needs to be redone. It is a quick and dirty solution.
                if (playerStats[0].BestCards.Cards[0].Rank < playerStats[1].BestCards.Cards[0].Rank) {
                    playerStats[0] = playerStats[1];
                 }                                                                                               
            }
            Console.WriteLine(playerStats);
            return playerStats;
        }
    }
}
