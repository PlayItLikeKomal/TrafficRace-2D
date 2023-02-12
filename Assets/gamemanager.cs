using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemanager : MonoBehaviour
{
    public GameObject gameplayrelated;
    public gamestates Gamestates;
    public float movespeed = 5f;
    public static gamemanager instance;
    public enum gamestates
    {
        none,
        mainmenu,
        gameplaying,
        paused,
        playerdied,
        gameover 
    }
    private void Awake()
    {
        instance= this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movegameplayobject();
    }
    private void movegameplayobject()
    {
        if (Gamestates == gamestates.gameplaying)
        {
            gameplayrelated.transform.position += Vector3.up * Time.deltaTime*movespeed;
        }
    }


}
