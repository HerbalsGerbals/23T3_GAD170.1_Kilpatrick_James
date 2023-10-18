using System.Collections;
using System.Collections.Generic;
using System.Net.Security;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int enemyHealth;
    // Enemy heath
    public int enemyLevel;
    //Enemy level part of a range
    int maxLevel = 5;
    int minLevel = 1;
    //The range that the enemies level can be
    public string enemyHasDied = "The troll has been defeated";
    public PlayerCharacter player;
    public float EXP;
    public bool enemyHasBeenDefeated;
    public string enemyRespawn = "A new troll has appeared!";

    // Start is called before the first frame update
    void Start()
    {
        EnemyLevel();
        //Makes sure each enemy spawned is a different level
        EnemyHealthByLevel();
        //Runs the public void of EnemyHealthByLevel making sure each level enemy has a certain amount of health
    }
    public void Update()
    {
        EnemyDeath();
        //Runs the function when enemy dies
    }
    public void EnemyHealthByLevel()
    {//Health depending on enemy level
        if (enemyLevel == 1)
        { 
            enemyHealth = 10;
          
        }
        if (enemyLevel == 2)
        { 
            enemyHealth = 20;
            
        }
        if (enemyLevel == 3)
        {
            enemyHealth = 30;
           
        }
        if (enemyLevel == 4)
        { 
            enemyHealth = 40;
          
        }
        if (enemyLevel == 5)
        { 
            enemyHealth = 50;
            
        }
        //Enemy health is 10 higher than the last level starting from 10
    }
    public void EnemyDeath()
    {
        //Message when enemy dies
        if (enemyHealth <= 0)
        {
            Debug.Log(enemyHasDied);
            EnemyLevel();
            //Runs the Code that allows the enemy to respawn
            player.ExperienceIncrease(EXP);
            //Updates Player characters EXP
        }
    }
    public void TakeDamage(int amount)
    {
        enemyHealth -= amount;
    }
    //Allows enemy to take damage
    public void EnemyLevel()
    {
        enemyLevel = Random.Range(minLevel, maxLevel);
        //The range the enemy can pull from
        EnemyHealthByLevel();
        //The health of the enemy
        Debug.Log(enemyRespawn);
    }
        
    //Code that makes sure every enemy is a random level from 1-5 and has the health adjusted for its level
}
