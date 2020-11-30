using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRotation : MonoBehaviour
{
    public float speedMove;

    private Vector3 moveVector;

    private CharacterController ch_controller;
    private MobileController mCont; 

    private void Start()
    {
        ch_controller = GetComponent<CharacterController>();
        mCont = GameObject.FindGameObjectWithTag("joystick2").GetComponent<MobileController>();
    }

    private void Update()
    {
        CharacterMove();
    }

    private void CharacterMove()
    {
        moveVector = Vector3.zero;

    
            
        if (Vector3.Angle(Vector3.forward, moveVector) > 1f || Vector3.Angle(Vector3.forward, moveVector) == 0)
        {
            Vector3 direct = Vector3.RotateTowards(transform.forward, moveVector, speedMove, 0.0f);
            transform.rotation = Quaternion.LookRotation(direct);
        }

        ch_controller.Move(moveVector * Time.deltaTime);

    }
}
