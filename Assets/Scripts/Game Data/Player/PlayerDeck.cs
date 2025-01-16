using System.Collections.Generic;
using HutongGames.PlayMaker.Actions;
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

    // adds a new card to the deck
    public void AddCard(CardData card)
    {
        
    }

    // creates a random card from the current list
    public int RandomCard()
    {
        int cardIndex = 0;
        return cardIndex; // returns index of list
    }
}
