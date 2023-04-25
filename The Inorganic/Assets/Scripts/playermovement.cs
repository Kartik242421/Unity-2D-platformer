using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public CharacterController2D controller;

    public float runSpeed = 40f;
    public Animator animator;
    public GameObject camera;
    float horizontalMove = 20f;
    bool jump = false;

    public object SpriteRenderer { get; internal set; }

  
    void Update()
    {
        animator.SetFloat("speed", Mathf.Abs(horizontalMove));
        horizontalMove = Input.GetAxisRaw("Horizontal");
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
    }

    void FixedUpdate()
    {
        
        controller.Move(horizontalMove, false, jump);
        jump = false;

    }
}
