using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject currentCheckpoint;
    private playermovement Player;
    public HealthManager healthManager;
    public GameObject deathParticle;
    public GameObject respawnParticle;
    public float respawnDelay;
    // Start is called before the first frame update
    void Start()
    {
        Player = FindObjectOfType<playermovement>();
        healthManager = FindObjectOfType<HealthManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RespawnPlayer()
    {
        StartCoroutine("RespawnPlayerCo");
    }
    public IEnumerator RespawnPlayerCo()
    {
        Debug.Log("Player Respawn");
        Instantiate(deathParticle, Player.transform.position, Player.transform.rotation);
        Player.enabled = false;
        Player.GetComponent<Renderer>().enabled=false;
        yield return new WaitForSeconds(respawnDelay);
        Player.transform.position = currentCheckpoint.transform.position;
        Player.enabled = true;
        Player.GetComponent<Renderer>().enabled = true;
        Instantiate(respawnParticle, currentCheckpoint.transform.position, currentCheckpoint.transform.rotation);
        healthManager.FullHealth();
        healthManager.isDead = false;
    }
}
