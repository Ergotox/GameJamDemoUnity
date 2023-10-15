using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMoveExploration : MonoBehaviour
{
    public Animator animator;
    public float runSpeed=5;
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
            
        }else if(Input.GetKey("left")){
            rb2D.velocity= new Vector2(-runSpeed, rb2D.velocity.y);
            
        }
        else if(Input.GetKey("down")){
            rb2D.velocity= new Vector2(rb2D.velocity.x,-runSpeed);
           
        }else if(Input.GetKey("right")){
            rb2D.velocity= new Vector2(runSpeed, rb2D.velocity.y);
        }
        if(Input.GetKeyUp("left")){
            rb2D.velocity= new Vector2(0,0);
            animator.SetBool("Left", false);
        }else if(Input.GetKeyUp("up")){
            rb2D.velocity= new Vector2(0,0);
            animator.SetBool("Up", false);
        }else if(Input.GetKeyUp("down")){
            rb2D.velocity= new Vector2(0,0);
            animator.SetBool("Down", false);
        }
    }
}
