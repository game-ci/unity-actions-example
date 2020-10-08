using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class OnCollisionEnterEvent : MonoBehaviour
{
    [SerializeField] private UnityEvent @event;
    [SerializeField] private string otherGameObjectName = "Sphere";
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == otherGameObjectName)
        {
            @event.Invoke();
        }
    }
}
