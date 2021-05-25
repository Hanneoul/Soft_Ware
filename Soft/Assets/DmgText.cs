using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DmgText : MonoBehaviour
{
    public float moveSpeed; //텍스트 이동속도
    public float alphaSpeed; //투명도 변환속도
    public float destroyTime;
    TextMeshPro text;
    Color alpha;
    public float dmg;
    void Start()
    {
        text = GetComponent<TextMeshPro>();
        alpha = text.color;
        text.text = dmg.ToString("N0");
        Invoke(nameof(DestroyObject), destroyTime);
    }

    void Update()
    {
        transform.Translate(new Vector3(0, moveSpeed * Time.deltaTime, 0));
        alpha.a = Mathf.Lerp(alpha.a, 0, Time.deltaTime * alphaSpeed);
        text.color = alpha;
    }

    void DestroyObject()
    {
        Destroy(gameObject);
    }
}
