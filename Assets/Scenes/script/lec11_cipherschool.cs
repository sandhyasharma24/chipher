using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lec11_cipherschool : MonoBehaviour
{//list are dynamic in nature i.e size canbe changed according to our need
    List<string> myList = new List<string>();
    // Start is called before the first frame update
    void Start()
    {//wihtout using public access modifier we can populate list like this,while wiht public we can do it with the help of inspector in unity
        myList.Add("sandhya");
        myList.Add("nithin");
        for(int i =0; i < myList.Count; i++)
        {
            Debug.Log(myList[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
