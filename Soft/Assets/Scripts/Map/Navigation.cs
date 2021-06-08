using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Navigation : MonoBehaviour
{
    NavMeshAgent agent;
    int i = 1;


    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();

    }
    void Start()
    {
         agent.SetDestination(GameManager.instance.waypoints[i-1].transform.position);
    }

    void Update()
    {
        /*if(Vector3.Distance(gameObject.transform.position, gm.waypoints[i-1].transform.position)<0.5f)
        {
            Debug.Log("gogo");
        }*/
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("WayPoint"))
        {
            if (i < GameManager.instance.waypoints.Length)
            {
                Debug.Log("gogo");
                agent.SetDestination(GameManager.instance.waypoints[i].transform.position);
                i++;
            }
        }
    }
}
