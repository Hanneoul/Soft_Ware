using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Navigation : MonoBehaviour
{
    NavMeshAgent agent;

    public float x;
    public float y;
    public float z;

    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();

    }

    void Update()
    {
        agent.SetDestination(new Vector3(x, y, z));
    }
}
