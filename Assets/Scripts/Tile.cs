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
    public GameObject tower3;

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

        if (Input.GetMouseButtonDown(0))
        {
            if (tm.tower1)
            {
                Instantiate(tower1, transform.position, Quaternion.identity);
                rd.material.color = StartColor;
                tm.tower1 = false;
                //��ġ�� ����.
            }
            if (tm.tower2)
            {
                Instantiate(tower2, transform.position, Quaternion.identity);
                rd.material.color = StartColor;
                tm.tower2 = false;
                //��ġ�� ����.
            }
            if (tm.tower3)
            {
                Instantiate(tower3, transform.position, Quaternion.identity);
                rd.material.color = StartColor;
                tm.tower3 = false;
                //��ġ�� ����.
            }
        }
    }

    private void OnMouseUp() 
    {
        //Ÿ�� ��ġ�� ���콺 ������ ( Ÿ����ġ)
    }

    void Update()
    {
        
    }

    

}
