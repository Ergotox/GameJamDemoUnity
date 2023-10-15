using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ataque : MonoBehaviour
{
    [SerializeField] private float velocidad;
    [SerializeField] private float danio;

    private void Update()
    {
        transform.Translate(Vector2.right* velocidad* Time.deltaTime);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemigo"))
        {
            collision.GetComponent<Villain>().TomarDanio(danio);
            Destroy(gameObject);
        }
    }
}
