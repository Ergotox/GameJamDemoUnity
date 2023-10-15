using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMoveExploration : MonoBehaviour
{
    public Animator animator;
    public float runSpeed=2;
    Rigidbody2D rb2D;
    // Start is called before the first frame update
    void Start()
    {
        
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("up")){
            rb2D.velocity= new Vector2(rb2D.velocity.x,runSpeed);
            animator.SetBool("Up", true);
            animator.SetBool("Left", false);
            animator.SetBool("Down", false);
            animator.SetBool("Right", false);
        }else if(Input.GetKey("left")){
            rb2D.velocity= new Vector2(-runSpeed, rb2D.velocity.y);
            animator.SetBool("Left", true);
            animator.SetBool("Up", false);
            animator.SetBool("Down", false);
            animator.SetBool("Right", false);
        }
        else if(Input.GetKey("down")){
            rb2D.velocity= new Vector2(rb2D.velocity.x,-runSpeed);
            animator.SetBool("Down", true);
            animator.SetBool("Up", false);
            animator.SetBool("Left", false);
            animator.SetBool("Right", false);
        }else if(Input.GetKey("right")){
            rb2D.velocity= new Vector2(runSpeed, rb2D.velocity.y);
            animator.SetBool("Right", true);
            animator.SetBool("Up", false);
            animator.SetBool("Left", false);
            animator.SetBool("Down", false);
        }else{
            rb2D.velocity= new Vector2(0, 0);
            animator.SetBool("Up", false);
            animator.SetBool("Left", false);
            animator.SetBool("Down", false);
            animator.SetBool("Right", false);
        }
    }
}
