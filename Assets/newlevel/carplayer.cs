using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class carplayer : MonoBehaviour
{
   public bool carchanginglane;
    public float targetposition;
    public bool isplayercargoingleft;
    public float movespeed = 5f;
    public road road;
  // public float xposition = -1.03f;
    public float xrotation = 0f;
    public bool makeplayercarstright;
   // public uimanager uImanager;*/
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is  called once per frame
    void Update()
    { //keyboard
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            carchanginglane = true;
            targetposition = -2.6f;
            //this.transform.position = new Vector3(targetposition, transform.position.y, transform.position.z);
           // startleftmoving();

        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            carchanginglane = true;
              targetposition = 0.59f;
           //this.transform.position = new Vector3(targetposition, transform.position.y, transform.position.z);

            //startrightmoving();

        }
        if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            //stopmove();
        }

        //mob
        /*  if (Input.GetMouseButton(0))
          {
              Vector3 mousepos = Input.mousePosition;
              if (mousepos.x < Screen.width / 2f)
              {
                  startleftmoving();
              }
              if (mousepos.x > Screen.width / 2f)
              {
                  startrightmoving();
              }
          }

          if (Input.GetMouseButtonUp(0))
          {
              stopmove();
          }

          if (gamemanager.instance.Gamestates == gamemanager.gamestates.gameplaying)
          {
              changecarlane();
          }*/
        changecarlane();
    }

  /*  private void stopmove()
    {
        carchanginglane = false;
        makeplayercarstright = true;
    }

    private void startrightmoving()
    {
        carchanginglane = true;
        // targetposition = 4.75f;
        isplayercargoingleft = false;
        makeplayercarstright = false;
    }

    private void startleftmoving()
    {
        carchanginglane = true;
        isplayercargoingleft = true;
        makeplayercarstright = false;
    } */

    private void changecarlane()
    {
        if (carchanginglane && !makeplayercarstright)

        {
            Vector3 currentpos = transform.position;
            float xposition = Mathf.Lerp(currentpos.x, targetposition, Time.deltaTime * movespeed);
            this.transform.position = new Vector3(xposition, transform.position.y, transform.position.z);
            if (Mathf.Abs(currentpos.x - targetposition) < 0.05)
            {
                carchanginglane = false;
            }


            /*    if (isplayercargoingleft == true)
                {
                    if (xposition > -2.6f)
                    { //reducting time.deltatime in x position
                        xposition -= Time.deltaTime * movespeed;
                    }
                    if (xrotation < 1.4f)
                    {
                        xrotation += Time.deltaTime * movespeed * 2f;
                    }
                }
                else if (isplayercargoingleft == false)
                {
                    if (xposition <= 0.59f)
                    { //reducting time.deltatime in x position
                        xposition += Time.deltaTime * movespeed;
                    }
                    if (xrotation > -1.4f)
                    {
                        xrotation -= Time.deltaTime * movespeed * 2f;
                    }*/
        }

           // this.transform.position = new Vector3(xposition, transform.position.y, transform.position.z);
           // this.transform.rotation = Quaternion.Euler(0f, 0f, xrotation);
        } /*
        if (makeplayercarstright)
        {
            xrotation = Mathf.Lerp(xrotation, 0f, Time.fixedDeltaTime * movespeed);
            this.transform.position = new Vector3(xposition, transform.position.y, transform.position.z);
            this.transform.rotation = Quaternion.Euler(0f, 0f, xrotation);

            if (xrotation == 0f)
            {
                makeplayercarstright = false;
            }
        }



    }


    // player distroy
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "enemycar")
        {
            Destroy(other.gameObject);
            road.speed = 0f;
            gamemanager.instance.Gamestates = gamemanager.gamestates.playerdied;
            uImanager.activaterestartbutton();
            uImanager.savegamedata();
            this.gameObject.SetActive(false);


        }
        if (other.tag == "coin")
        {
            Destroy(other.gameObject);
            uImanager.incresecoin();
        }*/
    }  

    
