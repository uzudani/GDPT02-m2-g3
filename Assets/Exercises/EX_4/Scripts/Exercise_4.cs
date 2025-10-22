using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_4 : MonoBehaviour
{
    [SerializeField] int StartingNumber;
    void Start()
    {
        Debug.Log(StartingNumber);
        Debug.Log(++StartingNumber);
        Debug.Log(++StartingNumber);
    }

    void Update()
    {
        
    }
}
