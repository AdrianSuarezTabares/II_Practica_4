using UnityEngine;

public class CubeController : MonoBehaviour
{
    public float speed = 5f;  
    private Transform sphereTransform;  
    private GameObject sphere; 
    void Start()
    {
        sphere = GameObject.FindWithTag("White_Sphere");
    }

    void Update()
    {   
        sphereTransform = sphere.transform;
        Vector3 cubePosition = transform.position;
        Vector3 directionToSphere = sphereTransform.position - cubePosition;
        directionToSphere.y = 0; // Ignorar la altura
        Vector3 normalizedDirection = directionToSphere.normalized;
     
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(normalizedDirection * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-normalizedDirection * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 leftDirection = Vector3.Cross(normalizedDirection, Vector3.up);
            transform.Translate(leftDirection * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 rightDirection = Vector3.Cross(normalizedDirection, Vector3.up) * -1; // Inverso de la izquierda
            transform.Translate(rightDirection * speed * Time.deltaTime);
        }
        
        transform.LookAt(sphereTransform.position);
    }
}
