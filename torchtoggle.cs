using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class torchtoggle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Collided");
        if(Input.GetKey(KeyCode.Return))
        {
            GameObject pl = this.gameObject.transform.GetChild(0).gameObject;
            GameObject fl = this.gameObject.transform.GetChild(1).gameObject;
            if(pl.activeSelf==true)
            {
                pl.SetActive(false);
            }
            else
            {
                pl.SetActive(true);
            }
            if (fl.activeSelf == true)
            {
                fl.SetActive(false);
            }
            else
            {
                fl.SetActive(true);
            }
        }
    }
}
