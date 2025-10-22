using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
            // If I do this function in "Void Start", the message will appear just once.
            
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Hello World");
        // If I do this function in "Void Start", the message will appear infinite times.
    }
}
