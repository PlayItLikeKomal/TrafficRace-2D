using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausenresume : MonoBehaviour
{
    public void pauseresume()
    {
        if (Time.timeScale != 0)
        {
            Time.timeScale = 0;
            return;
        }
        if(Time.timeScale==0)

        { Time.timeScale = 1;
            return;
        }
    }
}
