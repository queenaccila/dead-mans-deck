using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BossData", menuName = "Scriptable Objects/BossData")]
public class BossData : ScriptableObject
{
    public int health; // current boss health
    public List<CardData> bossCards = new List<CardData>(); // list of cards the boss will use
}
