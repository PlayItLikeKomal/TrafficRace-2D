using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class timer : MonoBehaviour
{
    public TextMeshProUGUI timertext;
    public float timertime = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timertime -= Time.deltaTime/5f;
        writetotext(timertime.ToString("F2"));
     
    }

    void writetotext(string str_)
    {
        timertext.text = str_;
    }
}
