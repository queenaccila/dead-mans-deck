using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BossDeck", menuName = "Scriptable Objects/BossDeck")]
public class BossDeck : ScriptableObject
{
    // set list of cards the boss will use
    public List<CardData> bossCards = new List<CardData>();
}
