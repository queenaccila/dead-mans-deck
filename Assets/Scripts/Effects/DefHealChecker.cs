using UnityEngine;

public class DefHealChecker : MonoBehaviour
{
    // main effects - block, freeze, regeneration

    // block effects
    CardData.CardRarity blockEffect;

    // freeze effects
    CardData.CardType freezeType;
    int freezeCards;

    // regen effects
    int healTurns;
    float healHP;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // BLOCK
    public CardData.CardRarity checkBlockEffect(int cardID)
    {
        switch(cardID)
        {
            case 32:
                blockEffect = CardData.CardRarity.common;
                break;
            case 36:
                blockEffect = CardData.CardRarity.common;
                break;
            case 37:
                blockEffect = CardData.CardRarity.common;
                break;
            case 40:
                blockEffect = CardData.CardRarity.uncommon;
                break;
            case 42:
                blockEffect = CardData.CardRarity.rare;
                break;
        }
        
        return blockEffect;
    }

    // FREEZE
    public CardData.CardType checkFreezeType(int cardID)
    {
        switch(cardID)
        {
            case 30:
                freezeType = CardData.CardType.attack;
                break;
            case 31:
                freezeType = CardData.CardType.defense;
                break;
            case 35:
                freezeType = CardData.CardType.attack;
                break;
            case 38:
                freezeType = CardData.CardType.attack;
                break;
            case 39:
                freezeType = CardData.CardType.healing;
                break;
            case 41:
                freezeType = CardData.CardType.attack;
                break;
        }
        
        return freezeType;
    }

    // REGENERATION
    public int setHealTurns(int cardID)
    {
        switch(cardID)
        {
            case 47:
                healTurns = 3;
                break;
            case 48:
                healTurns = 2;
                break;
            case 51:
                healTurns = 4;
                break;
            case 52:
                healTurns = 4;
                break;
            case 54:
                healTurns = 4;
                break;
            case 55:
                healTurns = 5;
                break;
            case 56:
                healTurns = 4;
                break;
            case 57:
                healTurns = 5;
                break;
        }

        return healTurns;
    }

    public float setHealHP(int cardID)
    {
        switch(cardID)
        {
            case 47:
                healHP = 3;
                break;
            case 48:
                healHP = 4;
                break;
            case 51:
                healHP = 5;
                break;
            case 52:
                healHP = 4;
                break;
            case 54:
                healHP = 7;
                break;
            case 55:
                healHP = 6;
                break;
            case 56:
                healHP = 10;
                break;
            case 57:
                healHP = 8;
                break;
        }

        return healHP;
    }
}
