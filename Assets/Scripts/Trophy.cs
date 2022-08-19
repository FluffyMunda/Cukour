using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trophy : MonoBehaviour
{
    public GameObject winningScreenObject;
    public GameObject characterObject;
    public GameObject secondcamObject;
    private void OnTriggerEnter(Collider other)
    {
        winningScreenObject.SetActive(true);
        characterObject.SetActive(false);
        secondcamObject.SetActive(true);
    }
}
