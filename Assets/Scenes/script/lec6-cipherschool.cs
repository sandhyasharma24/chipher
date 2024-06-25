using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ifelsestmnts : MonoBehaviour
{
    public int age;
    // Start is called before the first frame update
    void Start()
    {
        if(age > 18){
            Debug.Log("you can vote");
        }
        else{
            Debug.Log("you cannot vote");
        }
 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
