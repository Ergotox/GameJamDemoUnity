using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaBoss : MonoBehaviour
{
    [SerializeField] private Image barra;

    private float vida = 50;
    private float cantidadBarra = 0;

    public void ActualizarBarraVidaBoss()
    {
        vida -= 10;

        //falta Automatizar
        cantidadBarra = vida/50;



        barra.fillAmount = cantidadBarra;

    }
}
