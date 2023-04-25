using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStarcontroller : MonoBehaviour
{
    public float speed = 20f;
    public CharacterController2D player;
    public Rigidbody2D rb;
    public float rotationSpeed;
    public int damageToGive;
    //public int pointsForKill;

    public GameObject bullet1;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<CharacterController2D>();
        rb = GetComponent<Rigidbody2D>();
        if (player.transform.position.x < transform.position.x)
        {
            speed = -speed;
            rotationSpeed = -rotationSpeed;

        }


    }
    void Update()
    {
        rb.velocity = new Vector2(speed, rb.velocity.y);
        rb.angularVelocity = rotationSpeed;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            HealthManager.HurtPlayer(damageToGive);
            Destroy(gameObject);
        }


    }
}
 
