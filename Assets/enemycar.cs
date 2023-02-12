using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemycar : MonoBehaviour
{
    public float movespeed = 0f;
    // Start is called before the first frame update
    void Start()
    {
        if (movespeed > 0f)
        {
            GetComponent<Rigidbody2D>().velocity = transform.up * Time.deltaTime * movespeed;
            // transform.Translate(transform.up * Time.deltaTime * movespeed);
        }
    }
}

    // Update is called once per frame
   // void Update()



