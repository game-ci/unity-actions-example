using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouWin : MonoBehaviour
{
    [SerializeField]
    private GameObject gameObjectToEnable;
    
    public void Run()
    {
        gameObjectToEnable.SetActive(true);
    }
}
