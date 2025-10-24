using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_8 : MonoBehaviour
{
    [SerializeField] int FinalVote;


    // Start is called before the first frame update
    void Start()
    {
        if (FinalVote == 10)
        {
            Debug.Log("A+");
        }
        else if (FinalVote == 9)
        {
            Debug.Log("A");
        }
        else if (FinalVote == 8 || FinalVote == 7)
        {
            Debug.Log("B");
        }
        else if (FinalVote == 6)
        {
            Debug.Log("C");
        }
        else if (FinalVote == 5)
        {
            Debug.Log("D");
        }
        else if(FinalVote == 4)
        {
            Debug.Log("F");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
