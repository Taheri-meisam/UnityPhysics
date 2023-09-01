using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inputCode : MonoBehaviour
{
    [SerializeField] float xVal;
    [SerializeField] float yVal;
    [SerializeField] float zVal;
    [SerializeField] float SpeedVal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xVal = Input.GetAxis("Horizontal") * Time.deltaTime * SpeedVal;
        zVal = Input.GetAxis("Vertical") * Time.deltaTime * SpeedVal;
        transform.Translate(xVal, yVal, zVal);      
    }
}
