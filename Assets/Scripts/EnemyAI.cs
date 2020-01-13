using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float chaseRange;
    [SerializeField] float stoppingDistance;

    float distanceToTarget = Mathf.Infinity;

    NavMeshAgent navMeshAgent;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        navMeshAgent.stoppingDistance = stoppingDistance;
    }

    void Update()
    {
        distanceToTarget = Vector3.Distance(target.position, transform.position);
        if (distanceToTarget <= chaseRange)
        {
            navMeshAgent.SetDestination(target.position);
        }
        else
        {
            navMeshAgent.SetDestination(transform.position);
        }
    }
    void OnDrawGizmosSelected()
    {
        // Display the chase radius when selected
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, chaseRange);
    }
}
