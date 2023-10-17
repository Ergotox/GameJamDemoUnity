using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraPoder : MonoBehaviour
{
    [SerializeField] private Image barra;
    [SerializeField] private GameObject animacionBarra; 

    private float a;
    private float carga = 0;
    private float cargaQueue = 0;
    public bool barrallena = false;

    private void Start()
    {

    }

    public void CambiarPoder()
    {
        
        a = carga / 10;

        barra.fillAmount = a;

        if (a == 1)
        {
            animacionBarra.gameObject.SetActive(true);
            barrallena= true;
            
        }
        else
        {
            if (barrallena == true && a < 1)
            {
                animacionBarra.gameObject.SetActive(false);
                barrallena = false;
            }

            if (a>1)
            {
                cargaQueue++;
            }
        }
    }

    public void AumentarBarra()
    {
        carga += 1;
    }
    public void BajarBarra()
    {
        carga -= 1;
    }

    public void VolverBarraZero()
    {
        barra.fillAmount = 0;
        a = 0;
        carga= cargaQueue;
        animacionBarra.gameObject.SetActive(false);
        CambiarPoder();
        cargaQueue = 0;
    }


}
