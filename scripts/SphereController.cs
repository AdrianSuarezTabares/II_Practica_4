using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour
{
    public float speed = 5f; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Inicializar un vector de movimiento en cero
        Vector3 moveDirection = Vector3.zero;

        
        if (Input.GetKey(KeyCode.W)) 
        {
            moveDirection += Vector3.forward;  
        }

        if (Input.GetKey(KeyCode.S))  
        {
            moveDirection += Vector3.back;  
        }

        if (Input.GetKey(KeyCode.A))  
        {
            moveDirection += Vector3.left;  
        }

        if (Input.GetKey(KeyCode.D))  
        {
            moveDirection += Vector3.right;  
        }

        // Aplicar el movimiento usando Translate
        transform.Translate(moveDirection * speed * Time.deltaTime);
    }
}
