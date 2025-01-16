using UnityEngine;

public class Boss : MonoBehaviour
{
    public BossDeck bossDeck;
    public int maxBossHealth = 100;
    public int currentBossHealth = 100;
    public int bossAtkHelper;
    public int bossDefHelper;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentBossHealth = maxBossHealth;
        bossAtkHelper = 0;
        bossDefHelper = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
