using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class RainInstanciate : MonoBehaviour
{
    public GameObject rainPrefab;
    [SerializeField] int frequcy;
    [SerializeField] float speed;
    [SerializeField] float initialTime;
    [SerializeField] float endTime;
    [SerializeField] int instances;
    // Start is called before the first frame update
    void Start()
    {
        initialTime = 5;
        endTime = 5.0f;
        frequcy = 10;
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > endTime)
        {
            for (int i = 0; i < frequcy; i++)
            {
                spawnRain();
                endTime -= Time.time;
            }

        }
        endTime = initialTime;
      }
    void spawnRain()
    {
        if( rainPrefab != null )
        {
            GameObject raindrop = Instantiate(rainPrefab);
            instances++;
            Destroy(raindrop, endTime);
            instances--;
            Debug.Log("Destroying object " + endTime);
        }
    }
}
