using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderController : MonoBehaviour
{
    public delegate void CylinderCollision(); // Delegado para el evento de colisión
    public static event CylinderCollision OnCylinderCollision; // Evento

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Cube") // Colisión con el cubo
        {
            if (OnCylinderCollision != null)
            {
                OnCylinderCollision.Invoke(); // Enviar evento a las esferas
            }
        }
    }
}
