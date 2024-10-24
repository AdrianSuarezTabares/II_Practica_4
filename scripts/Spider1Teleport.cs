using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spider1Teleport : MonoBehaviour
{
    public GameObject targetEgg; // Huevo objetivo al que se teletransportarán
    private TeleportObject teleportObject; // Referencia al script genérico

    void Start()
    {
        // Obtener la referencia del script genérico de teletransporte
        teleportObject = GetComponent<TeleportObject>();
    }

    void OnEnable()
    {
        // Suscribirse al evento del cubo
        ReferenceTrigger.OnCubeApproaching += TeleportToEgg;
    }

    void OnDisable()
    {
        // Desuscribirse para evitar errores
        ReferenceTrigger.OnCubeApproaching -= TeleportToEgg;
    }

    // Función para teletransportar la araña al huevo objetivo
    void TeleportToEgg()
    {
        teleportObject.TeleportTo(targetEgg);
    }
}