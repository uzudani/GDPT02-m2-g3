using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_5 : MonoBehaviour
{
    [SerializeField] int StartingNumber;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(StartingNumber);
        Debug.Log(--StartingNumber);
        Debug.Log(--StartingNumber);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
