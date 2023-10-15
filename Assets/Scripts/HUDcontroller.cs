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
        puntos.text = HeroBattle.Instance.puntostotales.ToString();
    }

    public void ActulizarPuntos(int puntoTotales)
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
