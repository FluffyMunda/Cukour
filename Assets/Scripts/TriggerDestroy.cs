using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDestroy : MonoBehaviour
{
    public GameObject cube;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") ;
        {
            Destroy(cube);
        }
    }
}
