using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Before");
        HelloWorld();
        HelloWorld();
        HelloWorld();
        //Debug.Log("After");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void HelloWorld()
    {
        Debug.Log("Hello World!");
        //Debug.Log("What a fine day!");
    }
}
