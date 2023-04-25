using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public int damageToGive;
    public int pointsForKill;
    public GameObject bullet1;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;


    }
    void OnTriggerEnter2D( Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            other.GetComponent<EnemyHealthManager>().giveDamage(damageToGive);
            Destroy(gameObject);
            //Instantiate(impactEffect, transform.position, transform.rotation);

            if (other.GetComponent<EnemyHealthManager>().getHealth() <= 0)
            {
                ScoreManager.pointsAdd = pointsForKill;
                ScoreManager.AddPoints();
            }
        }
        
        
    }
}
    // Update is called once per frame
    
