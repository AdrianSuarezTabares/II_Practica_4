using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spider2Follow : MonoBehaviour
{
    public GameObject targetObject; 
    private ObjectFollower objectFollower;

    void Start()
    {
        objectFollower = GetComponent<ObjectFollower>();
        objectFollower.enabled = false;  
    }

    void OnEnable()
    {
        ReferenceTrigger.OnCubeApproaching += ActivateFollower;
    }

    void OnDisable()
    {
        ReferenceTrigger.OnCubeApproaching -= ActivateFollower;
    }

    // Función que activa el seguimiento del objeto
    void ActivateFollower()
    {
        if (objectFollower != null && targetObject != null)
        {
            objectFollower.targetObject = targetObject; 
            objectFollower.enabled = true;  
        }
    }
}