using System.Collections.Generic;
using UnityEngine;

public class CardDeck
{
    public Dictionary<int, Card> cards;

    public CardDeck()
    {
        cards = new Dictionary<int, Card>();
    }

    // add a card to the deck
    public void AddCard(Card card)
    {
        if(!cards.ContainsKey(card.cardID))
        {
            cards.Add(card.cardID, card);
        }
    }

    // picks a random card from the deck
    public Card GetRandomCard()
    {
        if(cards.Count == 0)
        {
            return null;
        }

        List<int> keys = new List<int>(cards.Keys);
        System.Random rng = new System.Random();
        int index = rng.Next(keys.Count); // randomly selects a key from the dictionary
        int randomKey = keys[index];

        return cards[randomKey];
    }

    // return the current list of cards in the deck
    public Dictionary<int, Card> GetDeck()
    {   
        return cards;
    }

    // get a card using the id key
    public Card GetCardByID(int cardId)
    {
        if(cards.ContainsKey(cardId))
        {
            return cards[cardId];
        }
        return null;
    }
    
}
