using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class _11_11_Practice_CSV : MonoBehaviour
{
    void Start()
    {
        //Test라는 csv파일이 존재할경우
        TextAsset txtAsset = Resources.Load<TextAsset>("test");
        Debug.Log(txtAsset);
        string[] arrData = txtAsset.text.Split("\r\n");
        foreach(string one in arrData)
        {
            Debug.Log(one);
            string[] datas = one.Split(',');
            Debug.Log(int.Parse(datas[0]));
            Debug.Log(int.Parse(datas[1]));
            Debug.Log(int.Parse(datas[2]));
            Debug.Log(int.Parse(datas[3]));
        }
        //파일 입출력을 이용
        string path = Application.dataPath + "/Resources/" + "test.scv";
        using (StreamReader sr = new StreamReader(path))
        {
            string lineData = string.Empty;
            while((lineData = sr.ReadLine()) != null)
            {
                string[] datas = lineData.Split(',');
                Debug.Log(int.Parse(datas[0]));
                Debug.Log(int.Parse(datas[1]));
                Debug.Log(int.Parse(datas[2]));
                Debug.Log(int.Parse(datas[3]));
            }
            sr.Close();
        }
    }

    void Update()
    {
        
    }
}
