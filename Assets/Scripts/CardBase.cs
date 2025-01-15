using System;
using UnityEngine;

public class CardBase : MonoBehaviour
{
    public Card card; // reference the card class
    public string NewCardName;
    public Card.CardType type;
    public Card.CardEffect effect;
    public Card.CardRarity rarity;
    public int NewCardValue;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        NewCardName = card.cardName;
        NewCardValue = card.value;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // main function to use a card
    public void UseCard()
    {

    }

    // function for freeze effect
    public bool IsFrozen()
    {
        return true;
    }

    public bool IsStolen()
    {
        return true;
    }

}
