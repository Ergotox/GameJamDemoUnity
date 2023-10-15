using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HUDcontroller : MonoBehaviour
{
    
    public TextMeshProUGUI puntos;
    public GameObject[] vidas;

    void Update()
    {
        if (HeroBattle.Instance != null)
        {
            puntos.text = HeroBattle.Instance.puntostotales.ToString();
        }
    }

    public void ActualizarPuntos(int puntoTotales)
    {
        puntos.text = puntoTotales.ToString();
    }

    public void DesactivarVida(int indice)
    {
        vidas[indice].SetActive(false);
    }
    public void ActivarVida(int indice)
    {
        vidas[indice].SetActive(true);
    }

}
