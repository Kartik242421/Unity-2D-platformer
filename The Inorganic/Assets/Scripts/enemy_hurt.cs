using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_hurt : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "bullet")
        {
            StartCoroutine("EnemyHurt");

        }



    }

    public IEnumerator EnemyHurt()
    {
        Debug.Log("It's working");
        animator.SetBool("hurt", true);
        yield return new WaitForSeconds(0.2f);
        animator.SetBool("hurt", false);
        yield return null;
    }
}
