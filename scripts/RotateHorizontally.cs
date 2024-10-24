using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateHorizontally : MonoBehaviour
{
public float speed = 5f; 
public float rotationSpeed = 100f;  
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        RotateCube(horizontalInput);
        Move();
        Debug.DrawRay(transform.position, transform.forward * 2, Color.red);
    }

    private void RotateCube(float horizontalInput)
    {
        float rotationAmount = horizontalInput * rotationSpeed * Time.deltaTime;
        transform.Rotate(0, rotationAmount, 0);
    }

    private void Move()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
    }
}
