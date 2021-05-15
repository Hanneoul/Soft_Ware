using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public float x;
    public float z;

    public float hp; // HP
    public Slider enemy_Hp_Bar;

    public float tower1_damage; // tower1의 공격력
    public float tower2_damage;
    public int randomDmg_min;
    public int randomDmg_max;
    public int randomDmg;
    public float enemy_drop_money; // 드랍머니

    StageManager stageManager;

    void Start()
    {
        stageManager = GameObject.Find("StageManager").GetComponent<StageManager>();
    }

    void Update()
    {
        enemy_Hp_Bar.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 0.8f, gameObject.transform.position.z);
        enemy_Hp_Bar.value = Mathf.Lerp(enemy_Hp_Bar.value, hp, Time.deltaTime * 10f);

        Survive();
        Die();
        RandomAtk();
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
            GameManager.gameManager.money += enemy_drop_money;
        }
    }
    void RandomAtk()
    {
        randomDmg = Random.Range(randomDmg_min, randomDmg_max);
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
        else if (other.CompareTag("Tower_Attack_2"))
        {
            hp -= tower2_damage;

            //if (hp <= 0)
            //{
            //   Destroy(gameObject);
            //   Debug.Log("죽었다");
            //   gm.money += enemy2_drop_money;
            //}
        }
        else if (other.CompareTag("RandomDmgTower"))
        {
            hp -= randomDmg;
        }
    }
}
