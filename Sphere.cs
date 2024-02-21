using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    bool tester = false;
    // Start is called before the first frame update
    void Start()
    {
        tester = true;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(tester);
    }
}
