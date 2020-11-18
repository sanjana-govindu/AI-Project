using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class testtoggle : MonoBehaviour {
    GameObject po;
    GameObject pl;
    GameObject fl;
    //public GameObject door;
    bool entered = false;
    bool fentered = false;
    //public Text distance;
    public Text ttoggle;
    public Text fin;
    public Text complete;
    int finished;
    // Use this for initialization
    void Start () {
        finished = 0;
        ttoggle.gameObject.SetActive(false);
        fin.gameObject.SetActive(false);
        complete.gameObject.SetActive(false);
        //distance.text="Destination at "+()
    }

    // Update is called once per frame
    void Update()
    {
        if (entered && Input.GetKeyUp(KeyCode.Return))
        {

            if (pl.activeSelf == true)
            {
                pl.SetActive(false);
                Debug.Log("Point Light OFF");
            }
            else
            {
                pl.SetActive(true);
                Debug.Log("Point Light ON");
            }
            if (fl.activeSelf == true)
            {
                fl.SetActive(false);
                Debug.Log("Flame Light OFF");
            }
            else
            {
                fl.SetActive(true);
                Debug.Log("Flame Light ON");
            }
        }
        if(fentered && Input.GetKeyUp(KeyCode.Return))
        {
            fin.gameObject.SetActive(false);
            complete.gameObject.SetActive(true);
            Time.timeScale = 0;
            finished = 1;
        }
        if(finished==1)
        {
            if(Input.GetKeyDown(KeyCode.Return))
            {
                SceneManager.LoadScene(0);
                Time.timeScale = 1;
            }
            if(Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        //interact.gameObject.SetActive(false);
        Debug.Log("Entered Trigger");
        if (other.gameObject.tag == "torch")
        {
            ttoggle.gameObject.SetActive(true);
            po = other.gameObject;
            pl = po.gameObject.transform.GetChild(0).gameObject;
            fl = po.gameObject.transform.GetChild(1).gameObject;
            entered = true;
        }
        if(other.gameObject.tag == "Finish")
        {
            fentered = true;
            fin.gameObject.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        //interact.gameObject.SetActive(true);
        Debug.Log("Exited Trigger");
        if (other.gameObject.tag == "torch")
        {
            ttoggle.gameObject.SetActive(false);
            po = null;
            pl = null;
            fl = null;
            entered = false;
        }
        if (other.gameObject.tag == "Finish")
        {
            fentered = false;
            fin.gameObject.SetActive(false);
        }
    }
}
