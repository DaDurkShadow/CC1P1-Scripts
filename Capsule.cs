using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : MonoBehaviour
{
    float standard;
    int modify = 5; 
    
    // Start is called before the first frame update
    void Start()
    {
        standard = 1.5f;
        modify = 11;
        
        Debug.Log(standard.ToString());
        Debug.Log(modify);
        
    }

    // Update is called once per frame
    void Update()
    {
    }
}