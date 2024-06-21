using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variable : MonoBehaviour
{
    public int myInt =5;
    float myfloat =10.5f;
    bool mybool =true;
    public string myString;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("the value of my bool is: "+mybool);
        Debug.Log("the value of my float is: "+myfloat);
        Debug.Log("the value of x is: "+myInt);
        Debug.Log("my name is: "+myString);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
