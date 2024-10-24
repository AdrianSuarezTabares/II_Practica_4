using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportObject : MonoBehaviour
{
    public void TeleportTo(GameObject target)
    {
        if (target != null)
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.position = target.transform.position; // Cambiar la posición del Rigidbody
            }
            else
            {
                transform.position = target.transform.position;
            }
        }
    }
}
