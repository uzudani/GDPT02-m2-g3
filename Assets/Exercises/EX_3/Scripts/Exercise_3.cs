using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_3 : MonoBehaviour
{
    [SerializeField] int Number;
    void Start()
    {
        if (Number % 2 == 0)
        {
            Debug.Log("Il numero: " + Number + " � PARI.");
        }
        else
        { 
            Debug.Log("Il numero: " + Number + " � Dispari.");
        }
    }

    void Update()
    {
        
    }
}
