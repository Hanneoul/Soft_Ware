using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public Color StartColor;
    public Color SelectColor;
    Renderer rd;

    public TowerManager tm;

    public GameObject tower1;
    public GameObject tower2;
    public GameObject random_Tower;

    public float tower1_money; //설치비
    public float tower2_money;
    public float random_Tower_Money;
    void Start()
    {
        rd = GetComponent<Renderer>();
    }

    private void OnMouseExit() //타일 위치에서 마우스가 나왔을때
    {
        rd.material.color = StartColor;
    }

    private void OnMouseOver() //타일 위치에 마우스가 들어가있을때 (색깔 바뀜)
    {
        rd.material.color = SelectColor;

        if (Input.GetMouseButtonDown(0)) // 타워 설치
        {
            if(GameManager.gameManager.money<tower1_money || GameManager.gameManager.money<tower2_money)
            {
                Debug.Log("설치비 ㄴㄴ");
            }
            else
            {
                if (tm.tower1)
                {
                    //설치비 차감.
                    GameManager.gameManager.money -= tower1_money;
                    Instantiate(tower1, transform.position, Quaternion.identity);
                    rd.material.color = StartColor;
                    tm.tower1 = false;
                }
                else if(tm.tower2)
                {
                    GameManager.gameManager.money -= tower2_money;
                    Instantiate(tower2, transform.position, Quaternion.identity);
                    rd.material.color = StartColor;
                    tm.tower2 = false;
                }
                else if(tm.radomTower)
                {
                    GameManager.gameManager.money -= random_Tower_Money;
                    Instantiate(random_Tower, transform.position, Quaternion.identity);
                    rd.material.color = StartColor;
                    tm.radomTower = false;
                }
            }
            
        }
    }
}
