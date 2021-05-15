using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower1 : MonoBehaviour
{
    private Transform target;
    public float range = 3f;
    public float atkSpeed = 0.5f;

    [Header("Attributes")]

    public float fireRate = 1f;
    private float fireCountDown = 0f;

    [Header("Unity Setup Fields")]

    // 타워 몹 LookDirection 변수
    private Transform partToRotate;

    public float turnSpeed = 10f;

    public float Tower1_AttackPower=10f; //공격력

    public GameObject bulletPrf;
    public Transform firePoint;

    public string enemyTag = "Enemy";


    void Start()
    {
        InvokeRepeating("UpdateTarget", 0f, atkSpeed);
    }

    void UpdateTarget() //타겟조정
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);
        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;

        foreach (GameObject enemy in enemies)
        {
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);

            if (distanceToEnemy < shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                nearestEnemy = enemy;
            }
        }

        if (nearestEnemy != null && shortestDistance <= range)
        {
            target = nearestEnemy.transform;
        }
        else
        {
            target = null;
        }
    }

    void Update()
    {
        if (target == null)
            return;

        if (fireCountDown <= 0)
        {
            Shoot();
            fireCountDown = 1f / fireRate;
        }

        fireCountDown -= Time.deltaTime;


        Vector3 dir = target.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(dir);
        Vector3 rotate = Quaternion.Lerp(partToRotate.rotation, lookRotation, Time.deltaTime * turnSpeed).eulerAngles;
        partToRotate.rotation = Quaternion.Euler(0f, rotate.y, 0f);
    }

    void Shoot()
    {
        GameObject bulletGo = (GameObject)Instantiate(bulletPrf, firePoint.position, firePoint.rotation);
        Bullet1 bullet1 = bulletGo.GetComponent<Bullet1>();

        if (bullet1 != null)
            bullet1.Seek(target);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
