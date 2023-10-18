using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    public float EXP;
    //Exp leveling system
    public int plevel;
    // Player's level
    public Enemy enemy;
    // Pulls from the enemy's code
    public int attackValue;
    // The Attack's stat (how much damage the enemy takes)
    public float targetXp;
    // The required EXP needed to level up
    public float EXPIncrease;
    // Increases the EXP
    public void Start()
    {
        AttackValue();
        //starting attack power
        EXP = 0;
        // starts of with no exp
        plevel = 1;
        //starts off at level 1
        targetXp = 30;
        // Needs 30 exp to level up
        
    }
    public void Update()
    {
        //Player deals damage to enemy health
        if (Input.GetKeyDown(KeyCode.Space))
        {
            enemy.TakeDamage(attackValue);
        }
        AttackValue();
        //Updates the attack stat when level up happens
        ExperienceController(EXP);
        //Allows for EXP to be updated and earnt
    }
    public void AttackValue()
        //Code for Attack stat to increase and how much damage it does
    {
        attackValue = 5;
        if (plevel == 2)
        { 
            attackValue = (int)7.50;
        }
        if (plevel == 3)
        {
            attackValue = 10;
        }
        if (plevel == 4)
        {
            attackValue = (int)12.5;
        }
        if (plevel == 5)
        {
            attackValue = 15;
        }
        //Increases by 1.25 every Level
    }
    public void ExperienceController(float amount)
    {
        //Level up system
        if(EXP >= targetXp)
        {
            EXP = EXP - targetXp;
            // Makes sure overflow xp is not lost
            plevel++;
            // levels up
            targetXp = 30;
            //amount needed to level up 
            if (plevel == 2)
            { 
                targetXp = 40; 
            }
            if (plevel == 3)
            {
                targetXp = 50;
            }
            if (plevel == 4)
            { 
                targetXp = 60;
            }
            //Amount needed to level up increases by 10 every level
            
            
        }
    }
    public void ExperienceIncrease(float amount)
    {
        EXPIncrease = EXP += 10;
        //Code used to update EXP when enemy is slain (used in enemy code)
    }
    
}