using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorSonidos : MonoBehaviour
{
    public static ControladorSonidos Instance;
    private AudioSource audioSource;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            // Si ya hay una instancia, destruir este objeto
            Destroy(this.gameObject);
        }

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