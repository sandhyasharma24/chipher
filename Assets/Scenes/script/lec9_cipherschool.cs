using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lec9_cipherschool : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {//for-loop:-
     // for (int i =0;i<=10;i++)
     //{
     //  Debug.Log("value of i is: " + i);
     //}

        int i = 0;
        //while i is less than eual to 10 debug the value in console
        //while(i <= 10)
        //{
        //  Debug.Log("value of i is: " + i);
        //i++;
        //}

        //do while-loop:-loop will be executed atleast once
        do
        {
            Debug.Log("value of i is: " + i);
            i++;
        }
        while (i <= 10);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
