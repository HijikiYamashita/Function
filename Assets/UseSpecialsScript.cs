using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseSpecialsScript : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Start");
    }

    void Update()
    {
        Debug.Log("Update");
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OnCollisionEnte");
    }
}
