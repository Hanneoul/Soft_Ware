using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Enemy : MonoBehaviour
{
    public float x;
    public float z;

    public TextMesh hpText;
    public GameObject hudDmgText; // 데미지 텍스트
    public Transform hudPos;
    public float hp; // HP

    public Tower tower1; // tower1의 공격력
    public Tower tower2;
    public Tower ex_Tower;
    public RandomTower rdTower;

    public float enemy_drop_money; // 드랍머니

    StageManager stageManager;

    void Start()
    {
        stageManager = GameObject.Find("StageManager").GetComponent<StageManager>();
    }

    void Update()
    {
        if(hpText != null)
        {
            hpText.text = hp.ToString("N0");
        }

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
            GameManager.gameManager.money += enemy_drop_money;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //GameObject hudText = Instantiate(hudDmgText);
        //hudText.transform.position = hudPos.position;

        if (other.CompareTag("Tower_Attack"))
        {
            hp -= tower1.atk;
            //hudText.GetComponent<DmgText>().dmg = tower1.atk;
            Debug.Log("타워1에 맞음"+tower1.atk);
        }
        if (other.CompareTag("Tower_Attack_2"))
        {
            hp -= tower2.atk;
            //hudText.GetComponent<DmgText>().dmg = tower2.atk;
            Debug.Log("타워2에 맞음"+tower2.atk);
        }
        if (other.CompareTag("Random_Attack"))
        {
            rdTower.atk = Random.Range(rdTower.atk_Min, rdTower.atk_Max);
            hp -= rdTower.atk;
            //hudText.GetComponent<DmgText>().dmg = rdTower.atk;
            Debug.Log("Random Tower에 맞음"+rdTower.atk);
        }
        if (other.CompareTag("Ex_Tower_Attack"))
        {
            hp -= ex_Tower.atk;
            //hudText.GetComponent<DmgText>().dmg = ex_Tower.atk;
            Debug.Log("Ex_Tower에 맞음" + ex_Tower.atk);
        }
    }
}
