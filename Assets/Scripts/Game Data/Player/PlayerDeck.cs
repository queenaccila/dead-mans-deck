using System.Collections.Generic;
using UnityEngine;

public class PlayerDeck : MonoBehaviour
{
    public List<CardData> playerDeck = new List<CardData>(); // current cards in deck
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // adds a new card to the deck list
    public void AddCard(CardData card)
    {
        playerDeck.Add(card);
    }

    // creates a random card from the current list
    public CardData RandomCard()
    {
        if(playerDeck.Count == 0)
        {
            return null;
        }

        int randomIndex = Random.Range(0, playerDeck.Count);
        return playerDeck[randomIndex];
    }
}
