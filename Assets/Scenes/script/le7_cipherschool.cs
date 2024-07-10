using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lec7_cipherschool : MonoBehaviour
{
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        switch(score){
            case 10:
                Debug.Log("you got 10");
                break;
            case 20:
                Debug.Log("you got 20");
                break;
            case 30:
                Debug.Log("you got 30");
                break;
            default:
                Debug.Log("you got nothing");
                break;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}