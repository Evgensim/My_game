using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Speed = 0.5f;
    public float TimeLife = 1f;
    public EnemyScript enemy;
    //public float Damage = 25f;

    float timerLife = 0f;

    void Start()
    {
        timerLife = TimeLife;
       // enemy = gameObject.GetComponent<EnemyScript>();
    }

    void Update()
    {
        transform.Translate(Vector3.right * Speed * Time.deltaTime);

        timerLife -= Time.deltaTime;

        //Vector3 dir = enemy.transform.position - transform.position;
        float _speed = Speed * Time.deltaTime;

        if (timerLife <= 0)
        {
            // Время жизни пули закончилось
            timerLife = TimeLife;
            Destroy(gameObject);
        // } else 
        // {
        //     // Пуля попадает в цель
        //     enemy.SetDamage(Damage);
        //     Destroy(gameObject);
        //     return;
        // }
        }

        transform.Translate(new Vector3(0, 0, _speed));
    }

    void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);
    }

    // void OnCollisionEnter(Collision coll)
    //  {
    //      Debug.Log(coll);
    //      if(coll.gameObject.name == "Enemy")
    //      {
    //          enemy.SetDamage(Damage);
    //          //Destroy(coll.gameObject);
    //      }
    //      //this.gameObject.SetActive(false);
         
    //  }
}
