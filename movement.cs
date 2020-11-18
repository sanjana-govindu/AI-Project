using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public GameObject player;
    public int speed = 2;
    public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            player.transform.Translate(new Vector3(0 , 0, 1) * Time.deltaTime);
        }   
        if (Input.GetKey(KeyCode.DownArrow))
        {
            player.transform.Translate(new Vector3(0, 0, -1) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            player.transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            player.transform.Translate(new Vector3(-1, 0, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.RightShift))
        {
            player.transform.Translate(new Vector3(0, 0, 1) * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.RightShift))
        {
            player.transform.Translate(new Vector3(0, 0, -1) * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.RightShift))
        {
            player.transform.Translate(new Vector3(1, 0, 0) * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.RightShift))
        {
            player.transform.Translate(new Vector3(-1, 0, 0)* speed * Time.deltaTime);
        }
        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);

    }
}
