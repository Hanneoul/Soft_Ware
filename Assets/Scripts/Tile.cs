using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public Color StartColor; 
    public Color SelectColor;
    Renderer rd;
    StageManager stageManager;

    public TowerManager tm;
    public GameManager gm;

    public GameObject tower1;
    public GameObject tower2;
    public GameObject tower3;

    public float tower1_money;
    public float tower2_money;
    public float tower3_money;

    void Start()
    {
        rd = GetComponent<Renderer>();
        stageManager = GameObject.Find("StageManager").GetComponent<StageManager>();
    }

    private void OnMouseExit() //Ÿ�� ��ġ���� ���콺�� ��������
    {
        rd.material.color = StartColor;
    }

    private void OnMouseOver() //Ÿ�� ��ġ�� ���콺�� �������� (���� �ٲ�)
    {
        rd.material.color = SelectColor;

        if (Input.GetMouseButtonDown(0)) // Ÿ�� ��ġ
        {
            if (tm.tower1)
            {
                //��ġ�� ����.
                if (stageManager.money < tower1_money) Debug.Log("��ġ�� ����");
                else
                {
                    stageManager.money -= tower1_money;
                    Instantiate(tower1, transform.position, Quaternion.identity);
                    rd.material.color = StartColor;
                    tm.tower1 = false;
                }
            }
            if (tm.tower2)
            {
                //��ġ�� ����.
                if (stageManager.money < tower2_money) Debug.Log("��ġ�� ����");
                else
                {
                    stageManager.money -= tower2_money;
                    Instantiate(tower2, transform.position, Quaternion.identity);
                    rd.material.color = StartColor;
                    tm.tower2 = false;
                }
            }
            if (tm.tower3)
            {
                //��ġ�� ����.
                if (stageManager.money < tower3_money) Debug.Log("��ġ�� ����");
                else
                {
                    stageManager.money -= tower3_money;
                    Instantiate(tower3, transform.position, Quaternion.identity);
                    rd.material.color = StartColor;
                    tm.tower3 = false;
                }
            }
        }
    }

    private void OnMouseUp() 
    {
        
    }

    void Update()
    {
        
    }

    

}
