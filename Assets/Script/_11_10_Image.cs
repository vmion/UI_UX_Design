using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _11_10_Image : MonoBehaviour
{
    public Image image;
    public float fCoolTime;
    public float fSumTime;
    void Start()
    {
        fSumTime = fCoolTime;
    }
    public void InitCoolTime()
    {
        fSumTime = fCoolTime;
        /*
        GameObject obj = GameObject.Find("Score");
        Text scoreText = obj.GetComponent<Text>();
        scoreText.text = "버튼눌림";
        */
    }
    void Update()
    {
        if (image.fillAmount > 0)
        {
            fSumTime = (fSumTime - Time.deltaTime);
            image.fillAmount -= fSumTime / fCoolTime;
        }
    }
}
