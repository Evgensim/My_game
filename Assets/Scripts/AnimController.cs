using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour
{
    Animator animator;

    float vertical;
    float horizontal;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        vertical = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");

        if (vertical == 0)
        {
            animator.SetBool("Run", false);
            
        }

        if (vertical >= 0.1f)
        {
            animator.SetBool("Run", true);
        }
    }
}
