using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerManager : MonoBehaviour
{
    public bool tower1 = false;
    public bool tower2 = false;
    public bool tower3 = false;

    public void Tower1_Btn() //tower1��ư Ŭ���� Tile��ũ��Ʈ�� OnmouseOver�� ��.
    {
        tower1 = true;        
    }

    public void Tower2_Btn() //tower2��ư Ŭ���� Tile��ũ��Ʈ�� OnmouseOver�� ��.
    {
        tower2 = true;        
    }

    public void Tower3_Btn() //tower3��ư Ŭ���� Tile��ũ��Ʈ�� OnmouseOver�� ��.
    {
        tower3 = true;        
    }
}
