using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    public delegate void EggCollision(); // Delegado para el evento de colisión
    public static event EggCollision OnEggCollision; // Evento

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Cube") // Colisión con el cubo
        {
            if (OnEggCollision != null)
            {
                OnEggCollision.Invoke(); // Enviar evento a las esferas
            }
        }
    }
}