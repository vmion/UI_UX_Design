using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _11_14_Button : MonoBehaviour
{
    public Button button;
    void Start()
    {
        button.onClick.AddListener(ListenerTest);
        button.onClick.AddListener(ListenerTest2);
    }
    public void ListenerTest()
    {
        Debug.Log("ListenerTest");
    }
    public void ListenerTest2()
    {
        Debug.Log("ListenerTest2");
        button.onClick.RemoveListener(ListenerTest2);
    }
    public void OnClickButton()
    {
        Debug.Log("ButtonClick");
    }
    void Update()
    {
        
    }
}
