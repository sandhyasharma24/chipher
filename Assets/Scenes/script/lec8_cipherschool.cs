using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lec8_cipherschool : MonoBehaviour
{//this 'global'variable is known to every function and accible by everyone unlike local variable'res'.
    int global;
    // Start is called before the first frame update
    void Start()
    {
       Debug.Log(Add(4,5));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //by default functions are private
    public int Add(int a, int b)
    {//res is local variable i.e this variable is known inside thisfunction
        int res = a + b;
        return res;
    }
}
