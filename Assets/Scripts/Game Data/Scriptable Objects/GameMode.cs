using UnityEngine;

[CreateAssetMenu(fileName = "GameMode", menuName = "Scriptable Objects/GameMode")]
public class GameMode : ScriptableObject
{
    public enum Mode
    {
        story,
        arcade,
        tournament
    }

    public Mode currentMode;
}
