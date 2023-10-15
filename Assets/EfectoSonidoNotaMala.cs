using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfectoSonidoNotaMala : MonoBehaviour
{

    [SerializeField] private AudioClip FailNote;


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ControladorSonidos.Instance.EjecutarSonido(FailNote);
        }
        
    }
    
}
