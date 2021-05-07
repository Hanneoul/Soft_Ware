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

    public float tower1_money; //��ġ��

    void Start()
    {
        rd = GetComponent<Renderer>();
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
            if(gm.money<tower1_money)
            {
                Debug.Log("��ġ�� ����");
            }
            else
            {
                if (tm.tower1)
                {
                    //��ġ�� ����.
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
