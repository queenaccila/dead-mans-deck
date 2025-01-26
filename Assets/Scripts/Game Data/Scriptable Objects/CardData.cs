using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "CardData", menuName = "Scriptable Objects/CardData")]
public class CardData : ScriptableObject
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
        regular,
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
    public int cardID;
    public string cardName;
    public string cardDescription;
    public CardType type;
    public CardEffect effect;
    public CardRarity rarity;
    public int value;
    public Sprite sprite;
}
