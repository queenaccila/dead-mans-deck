using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BossData", menuName = "Scriptable Objects/BossData")]
public class BossData : ScriptableObject
{
    public int maxHealth; // maximum boss health
    public int currentHealth; // current health value to measure in-game
    public int attackHelper; // adds onto card attack if needed
    public int defenseHelper; // current defense to prevent player attacks
    public List<CardData.CardEffect> currentEffects = new List<CardData.CardEffect>(); // list of all current effects
}
