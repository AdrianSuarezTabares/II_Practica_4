using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubscribeSphere : MonoBehaviour
{
    public GameObject target;

    private ObjectFollower objectFollower;

    void Start()
    {
        // Obtener el componente ObjectFollower que controlará el seguimiento
        objectFollower = GetComponent<ObjectFollower>();
        objectFollower.enabled = false; // Desactivar el seguimiento al principio
    }

    void OnEnable()
    {
        // Suscribirse al evento del cilindro
        CollisionDetector.OnEggCollision += ActivateFollower;
    }

    void OnDisable()
    {
        // Desuscribirse del evento del cilindro
        CollisionDetector.OnEggCollision -= ActivateFollower;
    }

    void ActivateFollower()
    {
        // Asignar el objetivo y activar el script ObjectFollower
        objectFollower.targetObject = target;
        objectFollower.enabled = true; // Activar el seguimiento
    }
}
