using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class HeroBattle : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject dashSpriteUp1;
  
    void Start()
    {
        Vector2 pos = transform.position;
        print(pos);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        if(Input.GetKeyDown("up")&&pos.y<-2.005f){
            pos.y = -1.05f;
            pos.x = -6.96f;
            transform.position = pos;
            
        }else if(Input.GetKeyDown("up")&&pos.y>-2.005f&&pos.y<-0.02f){
            pos.y = 0.93f;
            pos.x = -5.95f;
            transform.position = pos;
        }
        if(Input.GetKeyDown("down")&&pos.y>-0.02f){
            pos.y = -1.05f;
            pos.x = -6.96f;
            transform.position = pos;
        }else if(Input.GetKeyDown("down")&&pos.y>-2.005f&&pos.y<-0.02f){
            pos.y = -2.99f;
            pos.x = -7.96f;
            transform.position = pos;
        }
    }
    
}
