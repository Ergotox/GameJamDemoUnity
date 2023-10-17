using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.Video;

public class HeroBattle : MonoBehaviour
{
    public static HeroBattle Instance { get; private set; }
        
    public int vida = 3;
    public int puntostotales
    { 
        get; private set;
    }
    
    [SerializeField] int PuntosSumar;
    [SerializeField] public HUDcontroller hud;
    [SerializeField] private BarraPoder barraPoder;

    public Animator animator { get; private set; }
    private int tempdesp = 0;

    void Start()
    {
        Vector2 pos = transform.position;
        print(pos);
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        if(Input.GetKeyDown("up")&&pos.y<-2.005f){
            pos.y = -1.05f;
            pos.x = -6.96f;
            transform.position = pos;
            tempdesp = 1;

        }else if(Input.GetKeyDown("up")&&pos.y>-2.005f&&pos.y<-0.02f){
            pos.y = 0.93f;
            pos.x = -5.95f;
            transform.position = pos;
            tempdesp = 1;
        }
        if(Input.GetKeyDown("down")&&pos.y>-0.02f){
            pos.y = -1.05f;
            pos.x = -6.96f;
            transform.position = pos;
            tempdesp = 1;
        }
        else if(Input.GetKeyDown("down")&&pos.y>-2.005f&&pos.y<-0.02f){
            pos.y = -2.99f;
            pos.x = -7.96f;
            transform.position = pos;
            tempdesp = 1;
        }


        animator.SetInteger("Desplazamiento", tempdesp);
        tempdesp = 0;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Note"))
        {
            puntostotales += PuntosSumar;
            barraPoder.AumentarBarra();
        }
        else
        {
            if (collision.gameObject.CompareTag("NoteMala"))
            {
                vida -= 1;
                puntostotales -= PuntosSumar;
                if (vida == 0)
                {

                    animator.SetBool("Muerte", true);
                    
                    SceneManager.LoadScene(2);
                }
                hud.DesactivarVida(vida);
                barraPoder.BajarBarra();
                //sonar musica de daño
            }
        }

        hud.ActualizarPuntos(puntostotales);
        barraPoder.CambiarPoder();

    }


    public void AnimacionGanador()
    {
        animator.SetBool("Ganador", true);
    }

}
