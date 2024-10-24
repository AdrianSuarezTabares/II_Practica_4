using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    public float speed = 5f;  
    private Rigidbody rb; 

    void Start()
    {
        rb = GetComponent<Rigidbody>();  
    }

    // void FixedUpdate() // Usar FixedUpdate para la física
    // {
    //     float moveHorizontal = 0f;
    //     float moveVertical = 0f;

    //     if (Input.GetKey(KeyCode.I)) // Adelante
    //     {
    //         moveVertical = 1f;
    //     }
    //     else if (Input.GetKey(KeyCode.K)) // Atrás
    //     {
    //         moveVertical = -1f;
    //     }

    //     if (Input.GetKey(KeyCode.J)) // Izquierda
    //     {
    //         moveHorizontal = -1f;
    //     }
    //     else if (Input.GetKey(KeyCode.L)) // Derecha
    //     {
    //         moveHorizontal = 1f;
    //     }

    //     // Crear un vector de movimiento basado en la entrada
    //     Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical).normalized * speed;

    //     // Asignar la velocidad calculada al Rigidbody para moverse
    //     rb.velocity = movement;
    // }
    void FixedUpdate() // Usar FixedUpdate para física
    {
        float moveHorizontal = 0f;
        float moveVertical = 0f;

        // Comprobar entradas de usuario para movimiento
        if (Input.GetKey(KeyCode.I)) // Adelante
        {
            moveVertical = 1f;
        }
        else if (Input.GetKey(KeyCode.K)) // Atrás
        {
            moveVertical = -1f;
        }

        if (Input.GetKey(KeyCode.J)) // Izquierda
        {
            moveHorizontal = -1f;
        }
        else if (Input.GetKey(KeyCode.L)) // Derecha
        {
            moveHorizontal = 1f;
        }

        // Crear un vector de movimiento basado en las entradas
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical).normalized * speed * Time.deltaTime;

        // Mover el Rigidbody usando MovePosition
        rb.MovePosition(rb.position + movement);
    }
}
