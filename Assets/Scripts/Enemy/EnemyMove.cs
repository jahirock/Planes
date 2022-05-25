using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Obliga a que quien tenga la script agregada como componente requiera un rigidbody 2D (en este caso)
[RequireComponent(typeof(Rigidbody2D))]
public class EnemyMove : MonoBehaviour
{
    public Transform target;

    public float speed;
    public float rotSpeed;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();        
    }

    void FixedUpdate()
    {
        float cO = transform.position.x - target.position.x; //Cateto opuesto
        float cA = target.position.y - transform.position.y; //Cateto adyacente
        float angle = Mathf.Atan2(cO, cA) * Mathf.Rad2Deg;  //Angulo hacia el jugador

        rb.rotation = angle;
        rb.velocity = transform.up * speed;
    }
}
