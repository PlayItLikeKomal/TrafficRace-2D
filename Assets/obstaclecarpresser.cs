using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaclecarpresser : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {  // ||=0r
       if(other.tag=="enemycar" || other.tag== "coingenerator")
        {
            Destroy(other.gameObject);
        }
    }
}
