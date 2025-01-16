using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance { get; private set; }
    public int maxHealth; // max health
    public int currentHealth; // current health to change dynamically
    // list of all current effects on player
    public List<CardData.CardEffect> currentEffects = new List<CardData.CardEffect>();
    public int attackHelper;
    public int defenseHelper;
    public int bossWins; // number of bosses won
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = maxHealth; // player health is full at beginning
        attackHelper = 0; // atk and def are reset at the beginning of a level
        defenseHelper = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // checking singleton instances
    void Awake()
    {
        DontDestroyOnLoad(gameObject);

        // to ensure only one instance exists
        if(Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }
}
