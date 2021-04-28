using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [HideInInspector] public static GameManager instance = null; //Singleton


    void Awake()
    {
        Debug.Log("GameManager:Awake() Start.");
        Screen.SetResolution(Screen.width, (Screen.width * 16) / 9 , true);
        Debug.Log("GameManager:Resolution Setting Done.");

        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

       DontDestroyOnLoad(gameObject);

       Debug.Log("GameManager:Awake() Done.");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("GameManager:Start() Start.");
        
        Debug.Log("GameManager:Start() Done.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
