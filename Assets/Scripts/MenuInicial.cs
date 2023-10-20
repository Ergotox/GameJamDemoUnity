using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour
{
   public void Jugar(){
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
   }

   public void Creditos(){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
   }

   public void Salir(){
         Debug.Log("Saliendo del juego...");
         Application.Quit();
   }
}
