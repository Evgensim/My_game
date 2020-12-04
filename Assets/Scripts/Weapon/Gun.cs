//using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    Animator animator;
    

    public float damage = 10f;
    public float range = 100f;
    public bool isShoot;

    public Camera fpsCam;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetButtonDown("Fire1"))
        // {
        
        // } else
        // {
        //     //animator.SetBool("Fire", false);
        // }
    }

    public void Shoot()
    {
        RaycastHit hit;
        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
           // animator.SetBool("Fire", true);
            //animator.SetBool("RunFire", false);
            
        }
    }

    public void NotShoot()
    {
         animator.SetBool("Fire", false);
         animator.SetBool("RunFire", false);
    }

    public void Run(){
        animator.SetBool("Fire", true);
    }

    public void jouRun()
    {
        animator.SetBool("RunFire", true);
        animator.SetBool("Fire", false);
    }

    public void jouNotRun()
    {
        animator.SetBool("RunFire", false);
        animator.SetBool("Fire", false);
    }
}
