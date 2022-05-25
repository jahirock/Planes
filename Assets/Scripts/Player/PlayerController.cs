using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

//Obliga a que quien tenga la script agregada como componente requiera un rigidbody 2D (en este caso)
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    private float movementX;
    private float movementY;
    public float speed;
    public int rotSpeed;

    public float maxSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnMove(InputValue movementValue)
    {
        //Se recibe el vector2 del input system
        Vector2 movementVector = movementValue.Get<Vector2>();
        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    private void FixedUpdate()
    {
        //Rota el objeto con los controles de X. (A, D)
        rb.rotation -= movementX * rotSpeed;
        //Acelera dependiendo de los controles en Y (W, S), con una velocidad minima y maxima.
        speed = Mathf.Clamp(speed + movementY, 1.5f, maxSpeed);

        //Le asigna esa velocidad en direccion del eje Y del objeto.
        rb.velocity = transform.up * speed;
    }
}

