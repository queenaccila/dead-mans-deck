using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "Scriptable Objects/PlayerData")]
public class PlayerData : ScriptableObject
{
    public int maxHealth; // maximum player health
    public int currentHealth; // current health value to measure in-game
    public CardDeck playerDeck;
    public int attackHelper; // adds onto card attack if needed
    public int defenseHelper; // current defense to prevent enemy attacks
    public List<Card.CardEffect> currentEffects = new List<Card.CardEffect>(); // list of all current effects
    public int gameWins; // keep track of number of bosses won
}
