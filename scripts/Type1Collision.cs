using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Type1Collision : MonoBehaviour
{
    public delegate void Type1CollisionDelegate(); // Delegado para el evento de colisión
    public static event Type1CollisionDelegate OnType1Collision; // Evento

    void OnCollisionEnter(Collision collision)
    {
        // Comprobar si la colisión es con el objeto con etiqueta "Cube"
        if (collision.gameObject.CompareTag("Cube"))
        {
            OnType1Collision?.Invoke(); // Enviar el evento si hay suscriptores
        }

        // Comprobar si la colisión es con el objeto con etiqueta "Egg"
        if (collision.gameObject.CompareTag("EggType2"))
        {
            SkinnedMeshRenderer skinnedRenderer = GetComponentInChildren<SkinnedMeshRenderer>();
            skinnedRenderer.material.color = Color.red; // Change color to red
        }
    }
}