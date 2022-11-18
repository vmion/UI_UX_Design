using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _11_18_Shop : MonoBehaviour
{
    public ScrollRect scrollRc;
    public _11_18_ShopSlot itemSlot;
    float scrollSpeed;
    void Start()
    {
        scrollSpeed = 0.3f;
        //콘텐츠 영역의 크기
        Vector2 size = scrollRc.content.sizeDelta;
        Debug.Log("content의 크기 = " + scrollRc.content.sizeDelta);
        Debug.Log("content의 x크기 = " + scrollRc.content.rect.width);
        Debug.Log("content의 y크기 = " + scrollRc.content.rect.height);
        //scrollRc.normalizedPosition = new Vector2(0.5f, 1.0f);
    }
    public void BuySomething()
    {
        Debug.Log("BuySomething");
        itemSlot.gameObject.SetActive(false);
    }
    void Update()
    {
        //scrollRc.normalizedPosition -= new Vector2(0, Time.deltaTime * scrollSpeed);
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject newItemSlot = GameObject.Instantiate<GameObject>(itemSlot.gameObject);
            newItemSlot.transform.SetParent(scrollRc.content.transform);
            newItemSlot.gameObject.SetActive(true);
        }
    }
}
