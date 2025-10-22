using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_7 : MonoBehaviour
{
    [SerializeField] int Number_a;
    [SerializeField] int Number_b;
    // Start is called before the first frame update
    void Start()
    {
        if (Number_a < Number_b)
        {
            Debug.Log(Number_a);
        }
        else
        {
            Debug.Log(Number_b);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
