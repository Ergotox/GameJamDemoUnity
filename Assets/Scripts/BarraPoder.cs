using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarraPoder : MonoBehaviour
{
    public static BarraPoder Instance { get; private set; }
    public Animator animator;
    private int a = 0;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void CambiarPoder()
    {
        a++;
        animator.SetInteger("estado", a);

        if (a == 9)
        {
            a = 0;
        }
    }
}
