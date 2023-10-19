using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorAtaque : MonoBehaviour
{
    [SerializeField] private Transform controladorAtaque;
    [SerializeField] private GameObject onda;
    [SerializeField] private BarraPoder barraPoder;
    [SerializeField] private GameObject GIF;

    private void Update()
    {

        if (Input.GetButtonDown("Fire1") && barraPoder.barrallena == true)
        {   
            AparecerGif();

            Ataque();
            barraPoder.VolverBarraZero();
        }

    }

    private void Ataque()
    {
        GetComponent<HeroBattle>().animator.SetTrigger("Ataque");
        Instantiate(onda, controladorAtaque.position, controladorAtaque.rotation);
        
    }

    private void AparecerGif()
    {
        Time.timeScale = 0f;
        StartCoroutine(DemorarCargarScene());
    }

    private IEnumerator DemorarCargarScene()
    {
        GIF.SetActive(true);
        yield return new WaitForSecondsRealtime(1.5f);
        GIF.SetActive(false);
        Time.timeScale = 1f;
    }
}
