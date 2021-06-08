using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SpawnManager : MonoBehaviour
{
    public GameObject NextSpawner;
    public GameObject enemy;
    Queue<GameObject> enemyPool;

    public float enemyNum;
    public float spawnCycle;

    void Awake()
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
        InvokeRepeating(nameof(SpawnEnemy), 1, spawnCycle);
        Invoke(nameof(StopSpawn), enemyNum * spawnCycle + 1);
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
        if(NextSpawner != null)
        {
            NextSpawner.GetComponent<SpawnManager>().RoundStart();
        }        
    }
}
