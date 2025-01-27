using UnityEngine;

public class AttackChecker : MonoBehaviour
{
    // burn effects
    int burnTurns;
    float addBurn;

    // poison effects
    int poisonTurns;
    float addPoison;

    // bleed effects
    float addBleed;

    // stun turns
    int stunTurns;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // BURN
    public int addBurnTurns(int cardID)
    {
        switch(cardID)
        {
            case 5:
                burnTurns = 2;
                break;
            case 6:
                burnTurns = 2;
                break;
            case 12:
                burnTurns = 2;
                break;
            case 13:
                burnTurns = 2;
                break;
            case 19:
                burnTurns = 3;
                break;
        }

        return burnTurns;
    }

    public float addBurnHealth(int cardID)
    {
        switch(cardID)
        {
            case 5:
                addBurn = 5;
                break;
            case 6:
                addBurn = 4;
                break;
            case 12:
                addBurn = 7;
                break;
            case 13:
                addBurn = 9;
                break;
            case 19:
                addBurn = 8;
                break;
        }

        return addBurn;
    }

    // POISON

    public int addPoisonTurns(int cardID)
    {
        switch(cardID)
        {
            case 7:
                poisonTurns = 3;
                break;
            case 8:
                poisonTurns = 3;
                break;
            case 14:
                poisonTurns = 3;
                break;
            case 15:
                poisonTurns = 3;
                break;
            case 20:
                poisonTurns = 5;
                break;
        }

        return poisonTurns;
    }

    public float addPoisonHealth(int cardID)
    {
        switch(cardID)
        {
            case 7:
                addPoison = 2;
                break;
            case 8:
                addPoison = 3;
                break;
            case 14:
                addPoison = 5;
                break;
            case 15:
                addPoison = 6;
                break;
            case 20:
                addPoison = 5;
                break;
        }

        return addPoison;
    }

    // BLEED
    public float addBleedMeter(int cardID)
    {
        switch(cardID)
        {
            case 17:
                addBleed = 10;
                break;
            case 22:
                addBleed = 18;
                break;
            case 24:
                addBleed = 25;
                break;
            default:
                addBleed = 0;
                break;
        }

        return addBleed;
    }

    public int addStunTurns(int cardID)
    {
        switch(cardID)
        {
            case 9:
                stunTurns = 1;
                break;
            case 16:
                stunTurns = 1;
                break;
            case 21:
                stunTurns = 1;
                break;
            case 23:
                stunTurns = 2;
                break;
        }
        
        return stunTurns;
    }
}
