using UnityEngine;

public class CubeMover : MonoBehaviour
{
    public Vector3 moveDirection = new Vector3(1, 0, 0); // Dirección inicial (eje X)
    
    public float speed = 5f; // Velocidad inicial debe ser mayor que 1

    // Referencia al Rigidbody
    private Rigidbody rb;

    void Start()
    {
        if (transform.position.y != 0)
        {
            transform.position = new Vector3(transform.position.x, 0, transform.position.z);
        }
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 movement = moveDirection.normalized * speed * Time.deltaTime;  
        transform.Translate(movement);  
    }
}
