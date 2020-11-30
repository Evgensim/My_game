using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float MaxLife = 100f;
    public float life;
    
    public float pistolDamage = 20f;

    // Start is called before the first frame update
    void Start()
    {
        life = MaxLife;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetDamage(float value)
    {
        life -= value;

        if (life <= 0)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision coll)
     {
         Debug.Log(coll);
        SetDamage(pistolDamage); 
     }
}
