using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abcticlecarmover : MonoBehaviour
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
    {
        if (other.tag == "enemycar")
        {
            enemycar eny = other.GetComponent<enemycar>();
            giverandomspeed(eny);
        
        }

    }
    private void giverandomspeed(enemycar _enemycar)
    {
        float radomspeed = Random.Range(2f, 10f);
        if (_enemycar.movespeed == 0f) {

            _enemycar.movespeed = radomspeed;
        }
    }

}
