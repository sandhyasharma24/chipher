using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lec10_cipherschool : MonoBehaviour
{
    public int[] myArray=new int[5];
    //size allocation can be done from both unity and script
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < myArray.Length; i++) 
        
       {
            Debug.Log("the value of element is"+myArray[i]);
        } 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
