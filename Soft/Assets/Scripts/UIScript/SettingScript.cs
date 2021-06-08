using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingScript : MonoBehaviour
{
    public GameObject settingPopUp;

    void Start()
    {
        settingPopUp.SetActive(false);
    }
    void Update()
    {
        
    }

    public void SettingBtn()
    {
        settingPopUp.SetActive(true);
    }

    public void BackBtn()
    {
        settingPopUp.SetActive(false);
    }
}
