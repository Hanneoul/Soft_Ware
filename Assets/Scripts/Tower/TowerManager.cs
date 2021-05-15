using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerManager : MonoBehaviour
{
    public bool tower1 = false;
    public bool tower2 = false;
    public bool tower3 = false;

    public void Tower1_Btn() //tower1버튼 클릭시 Tile스크립트의 OnmouseOver로 감.
    {
        tower1 = true;        
    }

    public void Tower2_Btn() //tower2버튼 클릭시 Tile스크립트의 OnmouseOver로 감.
    {
        tower2 = true;        
    }

    public void Tower3_Btn() //tower3버튼 클릭시 Tile스크립트의 OnmouseOver로 감.
    {
        tower3 = true;        
    }
}
