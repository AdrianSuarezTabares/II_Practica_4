using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Type2Subscription : MonoBehaviour
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
        Type2Collision.OnType2Collision += ActivateFollower;
    }

    void OnDisable()
    {
        Type2Collision.OnType2Collision -= ActivateFollower;
    }

    void ActivateFollower()
    {
        objectFollower.targetObject = target;
        objectFollower.enabled = true; // Activar el seguimiento
    }
}
