using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ControladorNotes : MonoBehaviour
{
    [SerializeField] private Transform[] puntos;
    [SerializeField] private GameObject[] notas;

    [SerializeField] private float tiempoNotas;

    private float siguienteNote;


    private float[] posicionY;

    void Start()
    {
        posicionY = new float[]{0.349f, -1.625f, -3.653f};
    }

    void Update()
    {
        siguienteNote += Time.deltaTime;
        if (siguienteNote >= tiempoNotas)
        {
            siguienteNote = 0;

            CrearNote();
        }
    }

    private void CrearNote()
    {
        int numeroNote = Random.Range(0, notas.Length);

        int random = Random.Range(0, 3);
        Vector2 posicionAleatoria = new Vector2(7.62f, posicionY[random]);

        Instantiate(notas[numeroNote], posicionAleatoria, Quaternion.identity);



    }
}
