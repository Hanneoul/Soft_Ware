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

    private void OnMouseExit() //타일 위치에서 마우스가 나왔을때
    {
        rd.material.color = StartColor;
    }

    private void OnMouseOver() //타일 위치에 마우스가 들어가있을때 (색깔 바뀜)
    {
        rd.material.color = SelectColor;

        if (Input.GetMouseButtonDown(0))
        {
            if (tm.tower1)
            {
                Instantiate(tower1, transform.position, Quaternion.identity);
                rd.material.color = StartColor;
                tm.tower1 = false;
                //설치비 차감.
            }
            if (tm.tower2)
            {
                Instantiate(tower2, transform.position, Quaternion.identity);
                rd.material.color = StartColor;
                tm.tower2 = false;
                //설치비 차감.
            }
            if (tm.tower3)
            {
                Instantiate(tower3, transform.position, Quaternion.identity);
                rd.material.color = StartColor;
                tm.tower3 = false;
                //설치비 차감.
            }
        }
    }

    private void OnMouseUp() 
    {
        //타일 위치에 마우스 뗐을때 ( 타워설치)
    }

    void Update()
    {
        
    }

    

}
