using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorAtaque : MonoBehaviour
{
    [SerializeField] private Transform controladorAtaque;
    [SerializeField] private GameObject onda;


    private void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {;
            Ataque();
        }

    }

    private void Ataque()
    {
        GetComponent<HeroBattle>().animator.SetTrigger("Ataque");
        Instantiate(onda, controladorAtaque.position, controladorAtaque.rotation);
        
    }
}
