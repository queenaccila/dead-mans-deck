using UnityEngine;

public class CardLogic : MonoBehaviour
{
    public CardData card;
    int cardValue;
    int newCardValue = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        card.value = cardValue; // declare value in beginning
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // function for adding value to cards
    public int AddValue()
    {
        newCardValue += cardValue;
        return newCardValue;
    }

    // extra functions for special cards
}
