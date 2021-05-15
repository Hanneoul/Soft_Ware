using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;

    public void Stage_01_Btn()
    {
        SceneManager.LoadScene("Stage01");
    }

    public void Stage_02_Btn()
    {
        SceneManager.LoadScene("Stage02");
    }

    public void Stage_03_Btn()
    {
        SceneManager.LoadScene("Stage03");
    }

    public void Stage_04_Btn()
    {
        SceneManager.LoadScene("Stage04");
    }
}