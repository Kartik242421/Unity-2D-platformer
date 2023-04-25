using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class HealthManager : MonoBehaviour
{
    public static int playerHealth;
    public int  maxPlayerHealth;

    private LevelManager levelManager;
    public bool isDead;
    
    // Start is called before the first frame update
    void Start()
    {
        
        playerHealth = maxPlayerHealth;

        levelManager = FindObjectOfType<LevelManager>();
        isDead = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerHealth <= 0 && !isDead)
        {
            levelManager.RespawnPlayer();
            isDead = true;
            
        }
        
    }
    public static void HurtPlayer(int damageToGive)
    {
        playerHealth -= damageToGive;
    }
    public void FullHealth()
    {
        playerHealth = maxPlayerHealth;
    }
}
