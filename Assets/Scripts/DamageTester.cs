using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTester : MonoBehaviour
{
    //Public means variable can be accessed by outside scripts
    public float health;
    //Health stat
    public int attackStrength;
    //Attack stat
    public StatsManager enemyStatsManager;
    public Enemy enemy;
    public PlayerCharacter Player;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //Player deals damage to enemy health
        if (Input.GetKeyDown(KeyCode.Space))
        {
            enemy.TakeDamage(attackStrength);
        }
            
    }
}
