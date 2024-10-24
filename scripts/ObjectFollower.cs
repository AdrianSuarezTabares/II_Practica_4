using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFollower : MonoBehaviour
{
    public GameObject targetObject; // Objeto a seguir, asignado públicamente
    public float followSpeed = 2.5f;  // Velocidad del objeto seguidor
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (targetObject != null) 
        {
            Vector3 directionToTarget = (targetObject.transform.position - transform.position).normalized;

            Vector3 movement = directionToTarget * followSpeed;

            rb.velocity = movement;
        }
    }
}
