using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myCode : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(0.2f, 1.0f, 2.0f); 
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0.1f, 0, 0);   
    }
}
