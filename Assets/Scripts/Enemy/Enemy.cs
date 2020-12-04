using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{

    private NavMeshAgent Mob;
    public GameObject Player;
    public float MobDistanceRun = 4.0f;
    private Animator zombie_animator;

    public float DiatAttack = 4.0f;
    

    // Start is called before the first frame update
    void Start()
    {
        Mob = GetComponent<NavMeshAgent>();
        zombie_animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        FollowPlayer();
      //  Attack();
    }

    public void FollowPlayer(){
        float distance = Vector3.Distance(transform.position, Player.transform.position);

        if(distance < MobDistanceRun)
        {
            Vector3 dirToPlayer = transform.position - Player.transform.position;
            Vector3 newPos = transform.position - dirToPlayer;
            Mob.SetDestination(newPos);
            //zombie_animator.SetBool("Run", true);
            // if(distance < 4.0f)
            // {
            //      zombie_animator.SetBool("Run", false);
            // }
        } else{
            //zombie_animator.SetBool("Run", false);
        }
    }

    // public void Attack(){
    //     float distance = Vector3.Distance(transform.position, Player.transform.position);
    //     if(distance < DiatAttack)
    //     {
    //         zombie_animator.SetBool("Attack", true);
    //         zombie_animator.SetBool("Run", false);
    //     } else{
    //         zombie_animator.SetBool("Attack", false);
    //         zombie_animator.SetBool("Run", true);
    //     }
    // }
}
