using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Type1Subscription : MonoBehaviour
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
        Type1Collision.OnType1Collision += ActivateFollower;
    }

    void OnDisable()
    {
        Type1Collision.OnType1Collision -= ActivateFollower;
    }

    void ActivateFollower()
    {
        objectFollower.targetObject = target;
        objectFollower.enabled = true; // Activar el seguimiento
    }
}
