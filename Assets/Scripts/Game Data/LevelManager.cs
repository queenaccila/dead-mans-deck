using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public Player player;
    public PlayerDeck playerDeck; // the player deck using player prefab
    public Boss boss; // data on the boss
    public bool IsPlayerTurn = true; // checks to see if it's player's turn or not

    public bool GameStart = false;
    public bool GameFinish = false;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckGameOver()
    {
        if(player.currentHealth <= 0)
        {
            GameFinish = true;
            
        } else if(boss.currentBossHealth <= 0)
        {
            GameFinish = true;
        }
    }
}
