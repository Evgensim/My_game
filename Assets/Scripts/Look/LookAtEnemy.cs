using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtEnemy : MonoBehaviour
{
    public GameObject enemy;
    public GameObject fovStartPoint;
    public float lookSpead = 200;
    public float maxAngle = 90;

    private Quaternion targetRotation;
    private Quaternion lookAt;

     void Update()
    {
        if (EnemyInFieldOfView(fovStartPoint))
        {

        Vector3 direction = enemy.transform.position - transform.position;
        targetRotation = Quaternion.LookRotation(direction);
        lookAt = Quaternion.RotateTowards(transform.rotation, targetRotation, Time.deltaTime * lookSpead);
        transform.rotation = lookAt;    
        }
        else
        {
            targetRotation = Quaternion.Euler(0, 0, 0);
            transform.localRotation = Quaternion.RotateTowards(transform.localRotation, targetRotation, Time.deltaTime * lookSpead);
        }
    }

    bool EnemyInFieldOfView(GameObject looker)
    {
        Vector3 targetDir = enemy.transform.position - transform.position;
        float angle = Vector3.Angle(targetDir, looker.transform.forward);

        if (angle < maxAngle)
        {
            return true;
        }
        else
        {
            return false;
        }
    }   
}
