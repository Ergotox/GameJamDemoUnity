using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Villain : MonoBehaviour
{
    [SerializeField] private float vida;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();

    }

    public void TomarDanio(float danio)
    {
        vida -= danio;
        if (vida <= 0)
        {
            Muerte();
        }
    }

    private void Muerte()
    {
        //llamar la animacion "Muerte"
        Destroy(gameObject);
    }
}
