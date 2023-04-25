using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour
{
    public int enemyhealth = 80;
    public GameObject deathEffect;
    public int pointsOnDeath;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyhealth <= 0)
        {
            Instantiate(deathEffect, transform.position, transform.rotation);
            Destroy(gameObject);
            ScoreManager.pointsAdd = pointsOnDeath;
            ScoreManager.AddPoints();

        } 
        
    }
    public void giveDamage(int damageToGive)
    {
        enemyhealth -= damageToGive;
        

    }

    public int getHealth()
    {
        return enemyhealth;
    }
}
