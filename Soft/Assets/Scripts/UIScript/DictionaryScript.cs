using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DictionaryScript : MonoBehaviour
{
    public GameObject dictionaryPopUp;
    public GameObject scrollView_enemy;
    public GameObject scrollView_tower;

    void Start()
    {
        dictionaryPopUp.SetActive(false);
       
    }

    void Update()
    {
        
    }

    public void DictionaryBtn() //초기 = 타워 설정창
    {
        dictionaryPopUp.SetActive(true);
        scrollView_enemy.SetActive(false);
    }

    public void BackBtn()
    {
        dictionaryPopUp.SetActive(false);
    }
    
    public void Dic_Tower()
    {
        scrollView_enemy.SetActive(false);
        scrollView_tower.SetActive(true);
    }

    public void Dic_Enemy()
    {
        scrollView_enemy.SetActive(true);
        scrollView_tower.SetActive(false);
    }
}
