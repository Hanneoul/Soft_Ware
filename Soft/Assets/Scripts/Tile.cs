using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public Color StartColor;
    public Color SelectColor;
    Renderer rd;

    public TowerManager tm;
    public GameManager gm;

    public GameObject tower1;

    public float tower1_money; //설치비

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
            if(gm.money<tower1_money)
            {
                Debug.Log("설치비 ㄴㄴ");
            }
            else
            {
                if (tm.tower1)
                {
                    //설치비 차감.
                    gm.money -= tower1_money;
                    Instantiate(tower1, transform.position, Quaternion.identity);
                    rd.material.color = StartColor;
                    tm.tower1 = false;
                }
            }
            
        }
    }
    void Update()
    {
        
    }
}
