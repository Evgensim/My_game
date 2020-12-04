
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyTestCont : MonoBehaviour
{

    NavMeshAgent agent;

    GameObject target;

    private Animator zombie_animator;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        target = GameObject.FindGameObjectWithTag("Player");
         zombie_animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(transform.position, target.transform.position);
        if (dist < 2)
        {
            StopEnemy();
            
            zombie_animator.SetBool("Attack", true);
            zombie_animator.SetBool("Run", false);
        } else 
        {
            if (dist > 20)
            {
                StopEnemy();
                zombie_animator.SetBool("Run", false);
                zombie_animator.SetBool("Attack", false);
            } else {
            GoToTarget();
            zombie_animator.SetBool("Attack", false);
            zombie_animator.SetBool("Run", true);
            }
        } 
        
    }

   

    private void GoToTarget()
    {
        agent.isStopped = false;
        agent.SetDestination(target.transform.position);
    }

    private void StopEnemy()
    {
        agent.isStopped = true;
    }
}
