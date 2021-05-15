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

    public float tower1_money; //��ġ��
    public float tower2_money;
    public float random_Tower_Money;
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
            if(GameManager.gameManager.money<tower1_money || GameManager.gameManager.money<tower2_money)
            {
                Debug.Log("��ġ�� ����");
            }
            else
            {
                if (tm.tower1)
                {
                    //��ġ�� ����.
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
