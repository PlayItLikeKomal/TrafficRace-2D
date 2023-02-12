using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coingenerator : MonoBehaviour
{
    public GameObject coinprefab;
    private void Start()
    {
        generatecoinpattern();
    }
    private void generatecoinpattern()
    {  //no of coin generate in scence 
        int noofcoin = Random.Range(3,9);
        float zpos = 0;
        for (int i = 0; i < noofcoin; i++)
        {
           // float zpos = 0;
          Transform coin =Instantiate(coinprefab).transform;
            coin.parent = this.transform;
            coin.localPosition =new Vector2(0f,zpos);
                                   zpos+= 1.5f;

        }
    }
}
