using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorAtaque : MonoBehaviour
{
    [SerializeField] private Transform controladorAtaque;
    [SerializeField] private GameObject onda;
    [SerializeField] private BarraPoder barraPoder;

    private void Update()
    {

        if (Input.GetButtonDown("Fire1") && barraPoder.barrallena == true)
        {
            Ataque();
            barraPoder.VolverBarraZero();
        }

    }

    private void Ataque()
    {
        GetComponent<HeroBattle>().animator.SetTrigger("Ataque");
        Instantiate(onda, controladorAtaque.position, controladorAtaque.rotation);
        
    }
}
