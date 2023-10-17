using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Villain : MonoBehaviour
{
    [SerializeField] private float vida;
    [SerializeField] private HeroBattle hero;
    [SerializeField] private VidaBoss vidaBoss;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void TomarDanio(float danio)
    {
        vida -= danio;

        vidaBoss.ActualizarBarraVidaBoss();

        if (vida <= 0)
        {
            hero.AnimacionGanador();


            Muerte();


            SceneManager.LoadScene(2);

        }
    }

    private void Muerte()
    {
        //llamar la animacion "Muerte"
        Destroy(gameObject);
    }

}
