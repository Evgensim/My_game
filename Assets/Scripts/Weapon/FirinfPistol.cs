using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirinfPistol : MonoBehaviour
{
   public bool isAiming = false;
    public GameObject thePlayer;

    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            isAiming = true;
            thePlayer.GetComponent<Animation>().Play("Fire");
        }
        else
        {
            print("lox");
            isAiming = false;
        }
    }
}
