using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReferenceTrigger : MonoBehaviour
{
    public GameObject cube; // Referencia al cubo (player)
    public float triggerDistance = 10f; // Distancia mínima para activar la mecánica

    public delegate void CubeApproaching(); // Delegado para el evento
    public static event CubeApproaching OnCubeApproaching; // Evento estático

    void Update()
    {
        // Calcular la distancia entre el cubo y el objeto de referencia
        float distance = Vector3.Distance(cube.transform.position, transform.position);

        // Si el cubo está dentro del rango de proximidad
        if (distance <= triggerDistance)
        {
            // Invocar el evento
            if (OnCubeApproaching != null)
            {
                OnCubeApproaching.Invoke();
            }
        }
    }
}
