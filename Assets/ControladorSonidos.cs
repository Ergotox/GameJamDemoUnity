using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorSonidos : MonoBehaviour
{
    public static ControladorSonidos Instance;
    private AudioSource audioSource;

    private void Awake()
    {
       
        Instance = this;
        
        audioSource = GetComponent<AudioSource>();
    }

    public void EjecutarSonido(AudioClip sonido)
    {
        if (audioSource != null)
        {
            audioSource.PlayOneShot(sonido);
        }
        else
        {
            Debug.LogError("No se encontró un componente AudioSource en el objeto ControladorSonidos.");
        }
    }
}