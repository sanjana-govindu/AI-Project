using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class enemy2control : MonoBehaviour {

    public float lookRadius = 9f;
    public Text msgbox;
    Transform target;
    NavMeshAgent agent;
    Vector3 initpos;
    public AudioSource stepssound;
    // Use this for initialization
    void Start()
    {
        target = gamescript.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
        initpos = agent.transform.position;
        agent.speed = 50f;
        msgbox.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);
        if (distance <= lookRadius)
        { 
            agent.SetDestination(target.position);
        }
        else
        {
            agent.SetDestination(initpos);
        }
        if(distance<=2f)
        {
            msgbox.gameObject.SetActive(true);
            Time.timeScale = 0;
            if (Input.GetKeyDown(KeyCode.Return))
            {
                SceneManager.LoadScene(0);
                Time.timeScale = 1;
            }
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();
            }
        }
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position, 6f);
    }
}
