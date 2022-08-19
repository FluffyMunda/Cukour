using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntiCheat : MonoBehaviour
{
    public GameObject barrierObject;
    private void OnTriggerEnter(Collider other)
    {
        barrierObject.SetActive(true);
    }  
}
