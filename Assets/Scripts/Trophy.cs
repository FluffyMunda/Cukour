using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trophy : MonoBehaviour
{
    public GameObject winningScreenObject;
    private void OnTriggerEnter(Collider other)
    {
        winningScreenObject.SetActive(true);
    }
}
