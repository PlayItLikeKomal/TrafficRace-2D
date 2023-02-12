using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class uimanager : MonoBehaviour
{

    public GameObject gamename;
    public GameObject playbutton;
    public GameObject quitbitton;
    public GameObject scoreui;
    public GameObject coinui;
    public GameObject pausebuton;
    public GameObject highscorencoin;
    public GameObject restat;
    public TextMeshProUGUI scoretext;
    public TextMeshProUGUI highscoretext;
    public TextMeshProUGUI totalscoretext;//coin
    public int scoreint;
    public int coinint;
    public TextMeshProUGUI coinstext;
    private int highscore;
    private int totalcoin;




    private void Awake()
    {
        if (PlayerPrefs.HasKey("highscore"))
        {
            highscore = PlayerPrefs.GetInt("highscore");
        }
        if (PlayerPrefs.HasKey("totalcoin"))
        {
            totalcoin = PlayerPrefs.GetInt("totalcoin");
        }
        totalscoretext.text = totalcoin.ToString();
        highscoretext.text = highscore.ToString();
    }
    private void Start()
    {
        scoreint = 0;

        scoretext.text = scoreint.ToString();
        coinint = 0;
        coinstext.text = coinint.ToString();

        restat.SetActive(false);
        ToggleUI(false);
    }
    public void playgame()
    {
        gamename.SetActive(false);
        playbutton.SetActive(false);
        quitbitton.SetActive(false);
        highscorencoin.SetActive(false);

        ToggleUI(true);
        gamemanager.instance.Gamestates = gamemanager.gamestates.gameplaying;

        StartCoroutine("incrasescore");

    }
    public void restartgame()
    {
        SceneManager.LoadScene(0);
    }
    public void activaterestartbutton()
    {
        gamename.SetActive(true);
        restat.SetActive(true);
        quitbitton.SetActive(true);
    }
    public void quitgame()
    {
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#endif
        Application.Quit();
        Debug.Log("QUIT)");
    }
    private void ToggleUI(bool isactive)
    {
        scoreui.SetActive(isactive);
        coinui.SetActive(isactive);
        pausebuton.SetActive(isactive);
    }
    public void incresecoin()
    {
        coinint += 1;
        coinstext.text = coinint.ToString();
    }



    /* public void increasespeed()
     { 
         GetComponent<playercar>().movespeed += 2;
     }*/
    public void savegamedata()
    {
        if (scoreint > highscore)
        {
            highscore = scoreint;
        }
        totalcoin += coinint;//a=a+b
        PlayerPrefs.SetInt("highscore", highscore);
        PlayerPrefs.SetInt("totalcoin", totalcoin);
    }
    IEnumerator incrasescore()
    {
        yield return new WaitForSeconds(2f);
        while (true)
        {
            if (gamemanager.instance.Gamestates == gamemanager.gamestates.gameplaying)

            {
                scoreint += 1;
                scoretext.text = scoreint.ToString();
                //score controller
                if (scoreint > 50)
                {
                    // increasespeed();
                    SceneManager.LoadScene("levelmenu");


                    Debug.Log("quit");
                }
                yield return new WaitForSeconds(0.2f);
            }

            yield return new WaitForSeconds(0.2f);
        }

    }

}
    /*
 * int myActualScore = 0;
int nextLevelScore = 100;
public string level = "Level1001";
public void Update(){
      if(//Some stuff){
            myActualScore++;
      }
      if(myActualScore == nextLevelScore){
           Application.LoadLevel(level);
      }
}*/