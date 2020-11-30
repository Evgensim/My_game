//using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShootDemo : MonoBehaviour
{
    private AudioSource mAudio;
    private bool pointerDown;
    public Rigidbody projectile;
    public float speed = 20;
    public float TimeShoot = 1f;
    float timerShoot = 0f;
    public ParticleSystem muzzleFlash;
    bool isMoving;
    //public EnemyScript enemy;

    // Update is called once per frame
    void Start()
    {
        mAudio = GetComponent<AudioSource>();
    }

    void Update()
    {
        Shoot();
    }

    public void Shoot()
    {
        if (pointerDown)
        {
            timerShoot -= Time.deltaTime;

            if (timerShoot <= 0)
            {
                timerShoot = TimeShoot;
                mAudio.Play();
                muzzleFlash.Play();
                Rigidbody instantiatedProjectile = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;
                instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed));

            }
        }
    }

    public void ImagePointerDown()
    {
        Debug.Log("Pointer down!");
    }

    public void PointerDown()
    {
        pointerDown = true;
    }

    public void PointerUp()
    {
        pointerDown = false;
    }

    
}
