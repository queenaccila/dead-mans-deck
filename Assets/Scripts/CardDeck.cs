using System.Collections.Generic;
using UnityEngine;

public class CardDeck
{
    public List<Card> cards;

    public CardDeck()
    {
        cards = new List<Card>();
    }

    // add a card to the deck
    public void AddCard(Card card)
    {
        cards.Add(card);
    }

    // picks a random card from the deck
    public Card GetRandomCard()
    {
        if(cards.Count == 0)
        {
            return null;
        }

        System.Random rng = new System.Random();
        int index = rng.Next(cards.Count); // references a random card within the current card deck
        return cards[index];
    }
    
}
