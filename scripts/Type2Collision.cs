using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Type2Collision : MonoBehaviour
{
    public delegate void Type2CollisionDelegate(); // Delegado para el evento de colisión
    public static event Type2CollisionDelegate OnType2Collision; // Evento

    void OnCollisionEnter(Collision collision)
    {
        // Comprobar si la colisión es con el objeto con etiqueta "Cube"
        if (collision.gameObject.CompareTag("Cube"))
        {
            OnType2Collision?.Invoke(); // Enviar el evento si hay suscriptores
        }

        // Comprobar si la colisión es con el objeto con etiqueta "Egg"
        if (collision.gameObject.CompareTag("Egg"))
        {
            SkinnedMeshRenderer skinnedRenderer = GetComponentInChildren<SkinnedMeshRenderer>();
            skinnedRenderer.material.color = Color.blue;  
        }
    }
}
