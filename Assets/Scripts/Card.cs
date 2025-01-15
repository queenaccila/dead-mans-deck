using System;
using UnityEngine;

// base class for building a card deck
public class Card
{
    public enum CardType
    {
        attack,
        defense,
        healing,
        special
    }

    public enum CardEffect
    {
        burn,
        poison,
        stun,
        bleed,
        freeze,
        regeneration,
        weaken,
        block,
        steal,
        vengeance
    }

    public enum CardRarity
    {
        common,
        uncommon,
        rare,
        epic,
        legendary
    }

    // public variables to declare for a card
    public string cardName;
    public CardType type;
    public CardEffect effect;
    public CardRarity rarity;
    public int value;

    // card constructor
    public Card(string name, CardType type, CardEffect effect, CardRarity rarity, int value)
    {
        this.cardName = name;
        this.type = type;
        this.effect = effect;
        this.rarity = rarity;
        this.value = value;
    }
    
}
