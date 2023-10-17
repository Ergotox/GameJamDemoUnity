using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ControladorNotes : MonoBehaviour
{

    public AudioSource theMusic;


    public bool startPlaying;

    [SerializeField] private GameObject[] notas;

    [SerializeField] private float tiempoNotas;

    private float siguienteNote;

    private List<Vector2> posiciones = new List<Vector2>()
    {
        new Vector2(7.62f, 0.349f),
        new Vector2(7.62f, -1.625f),
        new Vector2(7.62f, -3.653f)
    };

    private List<int> secuenciaNotas = new List<int>()
    {
        2, // índice de la primera nota en el array de notas
        1, // índice de la segunda nota en el array de notas
        0, // índice de la tercera nota en el array de notas
        1, // índice de la cuarta nota en el array de notas
        2, // índice de la quinta nota en el array de notas
        1,
        0,
        1,
        2,
        1,
        0,
        2,
        2,
        0,
        0,
        1,
        2,
        1,
        2,
        1,
        2,
        1,  // primera secuencia
        2,
        1,
        0,
        1,
        2,
        1,
        0,
        1,
        2,
        1,
        0,
        2,
        2,
        0,
        0,
        1,
        2,
        1,
        2,
        1,
        2,
        1, // segunda secuencia
        2,
        1,
        0,
        1,
        2,
        1,
        0,
        1,
        2,
        1,
        0,
        2,
        2,
        0,
        0,
        1,
        2,
        1,
        2,
        1,
        2,
        1, // tercera secuencia
        2,
        1,
        0,
        1,
        2,
        1,
        0,
        1,
        2,
        1,
        0,
        2,
        2,
        0,
        0,
        1,
        2,
        1,
        2,
        1,
        2,
        1, // cuarta secuencia
        2,
        1,
        0,
        1,
        2,
        1,
        0,
        1,
        2,
        1,
        0,
        2,
        2,
        0,
        0,
        1,
        2,
        1,
        2,
        1,
        2,
        1, // quinta secuencia

        
    };

    private int indiceNotaActual = 0;

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
        int numeroNote = secuenciaNotas[indiceNotaActual];
        Vector2 posicion = posiciones[numeroNote];

        Instantiate(notas[Random.Range(0,notas.Length)], posicion, Quaternion.identity);

        indiceNotaActual++;
        if (indiceNotaActual >= secuenciaNotas.Count)
        {
            indiceNotaActual = 0;
        }
    }
}
