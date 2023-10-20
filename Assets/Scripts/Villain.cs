using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Villain : MonoBehaviour
{
    [SerializeField] private float vida;
    [SerializeField] private HeroBattle hero;
    [SerializeField] private VidaBoss vidaBoss;

    new private Renderer renderer;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
        renderer= GetComponent<Renderer>();
    }

    public void TomarDanio(float danio)
    {
        vida -= danio;

        vidaBoss.ActualizarBarraVidaBoss();

        if (vida <= 0)
        {
            hero.AnimacionGanador();

            //Invoke("CargarScene", 1.5f);
            Muerte();
            StartCoroutine(DemorarCargarScene());
        }
    }

    private IEnumerator DemorarCargarScene()
    {
        Time.timeScale = 0f;
        yield return new WaitForSecondsRealtime(1.1f); // el WaitForSecondsRealtime no se para por mas que el timescale este en 0
        SceneManager.LoadScene(2);

    }

    public void CargarScene()
    {
        SceneManager.LoadScene(2);
    }

    private void Muerte()
    {
        //llamar la animacion "Muerte"
        //Destroy(gameObject);
        renderer.enabled= false;
    }

}
