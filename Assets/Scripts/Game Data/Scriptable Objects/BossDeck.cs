using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BossDeck", menuName = "Scriptable Objects/BossDeck")]
public class BossDeck : ScriptableObject
{
    public List<CardData> bossCards = new List<CardData>();
}
