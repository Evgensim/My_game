//using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMehanics : MonoBehaviour
{
    public float speedMove;

    private Vector3 moveVector;

    private CharacterController ch_controller;
    private Animator ch_animator;
    private MobileController mCont; 

    bool isMoving;

    private void Start()
    {
        ch_controller = GetComponent<CharacterController>();
        ch_animator = GetComponent<Animator>();
        mCont = GameObject.FindGameObjectWithTag("joystick").GetComponent<MobileController>();
    }

    private void Update()
    {
        CharacterMove();
    }

    private void CharacterMove()
    {
        moveVector = Vector3.zero;
        moveVector.x = mCont.Horizontal() * speedMove;
        moveVector.z = mCont.Vertical() * speedMove;

        if (moveVector.x!=0||moveVector.z!=0) ch_animator.SetBool("Run",true);
        else ch_animator.SetBool("Run",false);

        // if (moveVector.x!=0||moveVector.z!=0) ch_animator.SetBool("Run",true);
        // else ch_animator.SetBool("Run",false);
        
            
        if (Vector3.Angle(Vector3.forward, moveVector) > 1f || Vector3.Angle(Vector3.forward, moveVector) == 0)
        {
            Vector3 direct = Vector3.RotateTowards(transform.forward, moveVector, speedMove, 0.0f);
            transform.rotation = Quaternion.LookRotation(direct);
        }

        ch_controller.Move(moveVector * Time.deltaTime);

    }

}
