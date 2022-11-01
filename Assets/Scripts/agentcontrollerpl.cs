using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class agentcontrollerpl : MonoBehaviour
{

    private NavMeshAgent agent;
    [SerializeField] private GameObject target;

    void Start()
    {
        
    }

    void Update()
    {
       agent = GetComponent<NavMeshAgent>();
        agent.destination = target.transform.position; 
    }
}
