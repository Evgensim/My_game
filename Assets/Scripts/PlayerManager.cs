using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    public GameObject player;    
    public static PlayerManager instance;

    void Awake()
    {
        instance = this;
    }
    
}
