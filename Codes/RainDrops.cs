using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RainDrops : MonoBehaviour
{

    [SerializeField] float xPosition;
    [SerializeField] float yPosition;
    [SerializeField] float zPosition;
    [SerializeField] float dropSpeed;
    private Vector3 position;

    // Start is called before the first frame update
    void Start()
    {
        xPosition = Random.Range(-8.0f, 8.0f);
        yPosition = Random.Range(-8.0f, 8.0f);
        yPosition = 20;
        position = new Vector3(xPosition, yPosition, Random.Range(-8.0f, 8.0f));
        transform.Translate(position);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
