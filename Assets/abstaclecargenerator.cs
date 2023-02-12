using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abstaclecargenerator : MonoBehaviour
{
    // Start is called before the first frame update
    //public GameObject obstaclecar;
    public GameObject[] obstaclecars;
    
    void Start()
    {
        // InvokeRepeating take a funcation name as string ,and take another parameter for hoe much time will it callthird parameter for repeat rate
        InvokeRepeating("generateobstaclecar", 5f,0f);
    }

    // Update is called once per frame
    void Update()
    {
    } private void generateobstaclecar()
    {
        if (gamemanager.instance.Gamestates == gamemanager.gamestates.gameplaying)
        {
            float cargeneratorpoint = gamemanager.instance.gameplayrelated.transform.position.y + 31f;
            //Instantiate take object and display on runtime
            int randomnum = Random.Range(0, 3);
            if (randomnum == 0)
            {
                Instantiate(obstaclecars[Random.Range(0, obstaclecars.Length)], new Vector3(-6.1f, cargeneratorpoint, 0f), Quaternion.identity);
            }
            else if(randomnum == 1)
            {
                Instantiate(obstaclecars[Random.Range(0, obstaclecars.Length)], new Vector3(0.8f, cargeneratorpoint, 0f), Quaternion.identity);
            }
            else
            {
                Instantiate(obstaclecars[Random.Range(0, obstaclecars.Length)], new Vector3(6.1f, cargeneratorpoint, 0f), Quaternion.identity);
            }
        }
    }
}
