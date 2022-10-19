using System;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class NavAgentBehavior: MonoBehaviour
{
    private NavMeshAgent agent;

    public Vector3Data playerLoc;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        agent.destination = playerLoc.value;
    }
}
