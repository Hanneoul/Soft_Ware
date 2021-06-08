using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageBtnLoad : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Stage_1(string stageName_1)
    {
        SceneManager.LoadScene(stageName_1);
    }
    public void Stage_2(string stageName_2)
    {
        SceneManager.LoadScene(stageName_2);
    }
    public void Stage_3(string stageName_3)
    {
        SceneManager.LoadScene(stageName_3);
    }
    public void Stage_4(string stageName_4)
    {
        SceneManager.LoadScene(stageName_4);
    }
    public void Stage_5(string stageName_5)
    {
        SceneManager.LoadScene(stageName_5);
    }

}
