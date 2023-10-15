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

    // Referencia al componente AudioSource
    [SerializeField] private AudioSource audioSource;

    void Update()
{
    // Obtener el tiempo actual de la canción
    float tiempoActual = audioSource.time;

    // Verificar si ha llegado al final de la secuencia de notas
    if (indiceNotaActual >= secuenciaNotas.Count)
    {
        return;
    }

    // Calcular el tiempo de creación de la próxima nota
    float tiempoSiguienteNota = tiempoNotas * (indiceNotaActual + 1);

    // Crear la nota si ha pasado el tiempo de creación
    if (tiempoActual >= tiempoSiguienteNota)
    {
        CrearNote();
    }
}

    private void CrearNote()
    {
        int numeroNote = secuenciaNotas[indiceNotaActual];
        Vector2 posicion = posiciones[numeroNote];

        Instantiate(notas[numeroNote], posicion, Quaternion.identity);

        indiceNotaActual++;
        if (indiceNotaActual >= secuenciaNotas.Count)
        {
            indiceNotaActual = 0;
        }
    }
}
