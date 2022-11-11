using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class _11_11_Text : MonoBehaviour
{
    public Text txt;
    char[] arr;
    float elapsed;
    int curIndex;
    public TextMeshProUGUI tmp;
    private void Awake()
    {
        string desc = "¾È³çÇÏ¼¼¿ä. ¶Ç ¸¸³µ±º¿ä.";
        arr = desc.ToCharArray();
        curIndex = 0;
        InvokeRepeating("DisplayDesc", 0f, 0.3f);
        tmp.text = "¾È³çÇÏ¼¼¿ä. ¶Ç ¸¸³µ±º¿ä.";
    } 
    public void DisplayDesc()
    {       
        if (curIndex >= arr.Length)
        {
            CancelInvoke("DisplayDesc");
            return;
        }
        txt.text += arr[curIndex];        
        curIndex++;
    }
    void Update()
    {
        /*
        elapsed += Time.deltaTime;    
        if(elapsed >= 0.3f && curIndex < arr.Length)
        {
            txt.text += arr[curIndex];
            curIndex++;
            elapsed -= 0.3f;
        }
        */
    }
}
