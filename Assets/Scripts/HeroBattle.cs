using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.Video;
using System.IO;

public class HeroBattle : MonoBehaviour
{
    public static HeroBattle Instance { get; private set; }
    private bool keyIsPressed = false;
    private string logFilePath = "keylog.txt";
    public int vida = 3;
    public int puntostotales
    { 
        get; private set;
    }
    
    [SerializeField] int PuntosSumar;
    [SerializeField] public HUDcontroller hud;

    void Start()
    {
        Vector2 pos = transform.position;
        if (File.Exists(logFilePath))
        {
            File.Delete(logFilePath);
        }
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

        //tener las teclas presionadas
        if (Input.GetKeyDown(KeyCode.U))
        {
            keyIsPressed = true;
            string logMessage = "Key pressed at time " + Time.realtimeSinceStartup+ "position x: -5.95f y: 0.93f" ;
            WriteLogToFile(logMessage);
        }
        else if (Input.GetKeyDown(KeyCode.J))
        {
            keyIsPressed = true;
            string logMessage = "Key pressed at time " + Time.realtimeSinceStartup+"position x: -6.96f y: -1.05f";
            WriteLogToFile(logMessage);
        }
        else if (Input.GetKeyDown(KeyCode.M))
        {
            keyIsPressed = true;
            string logMessage = "Key pressed at time " + Time.realtimeSinceStartup+"position x: -7.96f y: -2.99ff";
            WriteLogToFile(logMessage);
        }
        else if (keyIsPressed && !Input.anyKey)
        {
            keyIsPressed = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Note"))
        {
            puntostotales += PuntosSumar;
            hud.ActualizarPuntos(puntostotales);

        }
        else
        {
            if (collision.gameObject.CompareTag("NoteMala"))
            {
                vida -= 1;
                if (vida == 0)
                {
                    SceneManager.LoadScene(0);
                }
                hud.DesactivarVida(vida);

            }
        }

        
    }
    void WriteLogToFile(string message)
    {
        using (StreamWriter writer = new StreamWriter(logFilePath, true))
        {
            writer.WriteLine(message);
        }
    }

}
