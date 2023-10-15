using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BarraDeVida : MonoBehaviour
{
    // Start is called before the first frame update
    public Image barraDeVida;

    public float vidaActual;

    public float vidaMaxima;

    void Update(){
        barraDeVida.fillAmount = vidaActual / vidaMaxima;
    }

}
