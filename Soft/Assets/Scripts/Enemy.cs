using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float x;
    public float z;

    public float hp; // HP

    public float tower1_damage; // tower1의 공격력
    public float tower2_damage;
    public float enemy1_drop_money; // 드랍머니
    //public float enemy2_drop_money;

    public GameManager gm;
    StageManager stageManager;

    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        stageManager = GameObject.Find("StageManager").GetComponent<StageManager>();
    }

    void Update()
    {
        Survive();
        Die();
    }

    void Survive( )
    {
        if (this.gameObject.transform.position.x >= x 
            && this.gameObject.transform.position.z >= z)
        {
            Debug.Log("살았다"); 
            this.transform.parent.GetComponent<SpawnManager>().Push(gameObject);
            stageManager.surviveCnt++;
        }
    }

    void Die()
    {
        if (hp <= 0)
        {
            Debug.Log("죽었다");
            this.transform.parent.GetComponent<SpawnManager>().Push(gameObject);
            gm.money += enemy1_drop_money;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("맞았다");
        if (other.CompareTag("Tower_Attack"))
        {
            hp -= tower1_damage;

            //if (hp <= 0)
            //{
            //   Destroy(gameObject);
            //   Debug.Log("죽었다");
            //   gm.money += enemy1_drop_money;
            //}
        }
        if (other.CompareTag("Tower_Attack_2"))
        {
            hp -= tower2_damage;
            Debug.Log("dddd");

            //if (hp <= 0)
            //{
            //   Destroy(gameObject);
            //   Debug.Log("죽었다");
            //   gm.money += enemy2_drop_money;
            //}
        }
    }
}
