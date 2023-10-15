using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes : MonoBehaviour
{
    private Rigidbody2D rgbd2;

    [SerializeField] private float velocidadMovimiento;
    [SerializeField] private float distancia;
    [SerializeField] private LayerMask estaborde;
    [SerializeField] private bool hacedanio;

    public static bool menosvida;

    void Start()
    {
        rgbd2= GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rgbd2.velocity = new Vector2(velocidadMovimiento * transform.right.x, rgbd2.velocity.y);

        RaycastHit2D infoFin = Physics2D.Raycast(transform.position, transform.right, distancia, estaborde);

        if (infoFin)
        {
            Destroy(gameObject);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(transform.position, transform.position + transform.right * distancia);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            menosvida = true;     
        }
    }
}
