using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour
{
    float Sum(float a,float b)
    {
        return a + b;
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Sum(5, 5));
        
    }   

    // Update is called once per frame
    void Update()
    {
        
    }
}
