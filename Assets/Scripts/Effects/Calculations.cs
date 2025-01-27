using System;
using UnityEngine;

public class Calculations : MonoBehaviour
{
    // main variables
    int finalAtkCalculation;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int DefenseToAttack(int mainAttack, float affectedHealth, float affectedDefense)
    {
        if (mainAttack > (affectedDefense + affectedHealth))
        {
            float newAttack = Math.Max(0, (float)mainAttack - affectedDefense);
            finalAtkCalculation =  (int)newAttack;
        } else {
            mainAttack = finalAtkCalculation;
        }

        return finalAtkCalculation; // this needs to be subtracted from affected hp
    }
}
