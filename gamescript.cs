using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamescript : MonoBehaviour {
    #region Singleton

    public static gamescript instance;

    private void Awake()
    {
        instance = this;
    }


    #endregion

    public GameObject player;
    public GameObject enem1;
    public GameObject enem2;
    public GameObject enem3;

    void Start()
    {

    }
    void Update()
    {
        float dis1= Vector3.Distance(player.transform.position, enem1.transform.position);
        float dis2 = Vector3.Distance(player.transform.position, enem2.transform.position);
        float dis3 = Vector3.Distance(player.transform.position, enem3.transform.position);
        if (dis1<dis2 && dis1<dis3)
        {
            enem1.SetActive(true);
            enem2.SetActive(false);
            enem3.SetActive(false);
        }
        else if(dis2<dis1 && dis2<dis3)
        {
            enem1.SetActive(false);
            enem2.SetActive(true);
            enem3.SetActive(false);
        }
        else
        {
            enem1.SetActive(false);
            enem2.SetActive(false);
            enem3.SetActive(true);
        }
    }
}
