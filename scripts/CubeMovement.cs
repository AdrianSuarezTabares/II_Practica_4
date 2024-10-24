using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        float horizontalAxis = Input.GetAxis("Horizontal");
        float verticalAxis = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.UpArrow))
        {
            float result = speed * verticalAxis;
            Debug.Log("Up Arrow: " + result);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            float result = speed * verticalAxis;
            Debug.Log("Down Arrow: " + result);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            float result = speed * horizontalAxis;
            Debug.Log("Left Arrow: " + result);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            float result = speed * horizontalAxis;
            Debug.Log("Right Arrow: " + result);
        }
    }
}
