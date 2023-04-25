using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootAtPlayerInRange : MonoBehaviour
{
    public float playerRange;
    public GameObject enemyStar;
    public CharacterController2D player;
    public Transform launchPoint;
    public Animator animator;
    public float waitBetweenShots;
    private float shotCounter;
    void Start()
    {
        player = FindObjectOfType<CharacterController2D>();
        shotCounter = waitBetweenShots;
        animator = gameObject.GetComponent<Animator>();

    }

    void Update()
    {
        Debug.DrawLine(new Vector3(transform.position.x - playerRange, transform.position.y, transform.position.z), new Vector3(transform.position.x + playerRange, transform.position.y, transform.position.z));
        shotCounter -= Time.deltaTime;
        if (transform.localScale.x<0 && player.transform.position.x> transform.position.x && player.transform.position.x<transform.position.x+ playerRange && shotCounter<0)
        {
            
            Instantiate(enemyStar, launchPoint.position, launchPoint.rotation);
            StartCoroutine("EnemyAttack");
            shotCounter =waitBetweenShots;
        }
        if (transform.localScale.x > 0 && player.transform.position.x < transform.position.x && player.transform.position.x > transform.position.x - playerRange && shotCounter < 0)
        {
            
            Instantiate(enemyStar, launchPoint.position, launchPoint.rotation);
            StartCoroutine("EnemyAttack");
            shotCounter = waitBetweenShots;
            
        }
    }
    public IEnumerator EnemyAttack()
    {
        Debug.Log("It's working");
        animator.SetBool("attack", true);
        yield return new WaitForSeconds(0.2f);
        animator.SetBool("attack", false);
        yield return null;
    }


}
