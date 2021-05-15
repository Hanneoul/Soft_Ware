using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemy;
    Queue<GameObject> enemyPool;

    public float enemyNum;

    void Start()
    {
        enemyPool = new Queue<GameObject>();

        for (int i = 0; i < enemyNum; i++)
        {
            GameObject Enemy = Instantiate(enemy, gameObject.transform.position, Quaternion.identity);
            Enemy.transform.parent = gameObject.transform;
            Enemy.SetActive(false);
            enemyPool.Enqueue(Enemy);
        }
    }    

    public void RoundStart()
    {
        InvokeRepeating("SpawnEnemy", 0, 1);
        Invoke("StopSpawn", enemyNum);
    }

    public GameObject Pop()
    {
        return enemyPool.Dequeue();
    }

    public void Push(GameObject obj)
    {
        obj.SetActive(false);
        obj.transform.position = this.transform.position;
        enemyPool.Enqueue(obj);
    }

    void SpawnEnemy()
    {
        GameObject obj = Pop();
        obj.SetActive(true);
    }

    void StopSpawn()
    {
        CancelInvoke("SpawnEnemy");
    }
}