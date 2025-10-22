using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_2 : MonoBehaviour
{
    // Start is called before the first frame update
    public int Alfa;
    public int Bravo;
    public int Charlie;
    public int Delta;

    void Start()
    {
       int addition = Alfa + Bravo + Charlie + Delta;
        int multiplication = Alfa * Bravo * Charlie * Delta;
        int average = addition / 4;

        Debug.Log("Addition: " + addition);
        Debug.Log("Multiplication: " + multiplication);
        Debug.Log("Average: " + average);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
