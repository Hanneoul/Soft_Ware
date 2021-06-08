using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieFade : MonoBehaviour
{
    Color color;
    Animator ani;

    void Start()
    {
        ani = GetComponent<Animator>();
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        sr.material.color = new Color(sr.material.color.r, sr.material.color.g, sr.material.color.b, 1);
    }

    void Update()
    {
        
    }

    public void Player_FadeOut()
    {
       // SpriteRenderer sr = GetComponent<SpriteRenderer>();
       // sr.material.color = new Color(sr.material.color.r, sr.material.color.g, sr.material.color.b, 0);
       // ani.SetTrigger("Die");
    }
}
