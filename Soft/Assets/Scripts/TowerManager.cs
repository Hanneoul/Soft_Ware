using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerManager : MonoBehaviour
{
    public bool tower1 = false;
    public bool tower2 = false;
    public bool radomTower = false;

    public void Tower1_Btn() //tower1��ư Ŭ���� Tile��ũ��Ʈ�� OnmouseOver�� ��.
    {
        tower1 = true;
    }

    public void Tower2_Btn()
    {
        tower2 = true;
    }

    public void RandomTower_Btn()
    {
        radomTower = true;
    }

}
