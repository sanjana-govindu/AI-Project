using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class distance : MonoBehaviour {
    public GameObject door;
    public Text dis;
	// Use this for initialization
	void Start () {
        dis.text = "Destination at : " + (int)Vector3.Distance(transform.position, door.transform.position)+"m";
    }
	
	// Update is called once per frame
	void Update () {
        dis.text = "Destination at : " + (int)Vector3.Distance(transform.position, door.transform.position)+"m";
    }
}
