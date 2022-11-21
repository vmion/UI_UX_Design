using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _11_18_ShopSlot : MonoBehaviour
{
    public int slotIndex;
    Button button;
    void Start()
    {
        button = GetComponentInChildren<Button>();
        button.onClick.AddListener(OnClickBuyButton);
    }
    public void OnClickBuyButton()
    {
        Debug.Log(slotIndex.ToString() + "버튼클릭");
    }
    void Update()
    {
        
    }
}
