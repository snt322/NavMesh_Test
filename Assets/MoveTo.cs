using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveTo : MonoBehaviour
{
    public Transform goal;


    // Use this for initialization
    void Start()
    {
        NavMeshAgent agent = gameObject.GetComponent<NavMeshAgent>() as NavMeshAgent;
        agent.destination = goal.position;


    }

    // Update is called once per frame
    void Update()
    {

    }
}
