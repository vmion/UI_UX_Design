using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class _11_17_Inventory : MonoBehaviour, IPointerDownHandler, IPointerUpHandler,
    IBeginDragHandler, IDragHandler, IEndDragHandler
{   
    public Image moveIcon;
    public List<_11_17_InventorySlot> list;
    int selectedSlot;
    int dropSlot;
    string iconName;    
    void Start()
    {
        
    }
    public void OnPointerDown(PointerEventData _eventdata)
    {                      
        for(int i = 0; i < list.Count; i++)
        {           
            if(list[i].IsInRect(_eventdata.position))
            {
                if (list[i].icon.gameObject.activeSelf == true)
                {
                    moveIcon.transform.position = _eventdata.position;
                    iconName = list[i].icon.sprite.name;
                    moveIcon.sprite = Resources.Load<Sprite>(iconName);
                    moveIcon.gameObject.SetActive(true);
                    selectedSlot = i;                    
                    list[selectedSlot].icon.gameObject.SetActive(false);
                }                    
                Debug.Log(list[selectedSlot].gameObject.name + "º±≈√");
            }
        }
    }
    public void OnPointerUp(PointerEventData _eventdata)
    {
        moveIcon.transform.position = _eventdata.position;
        list[selectedSlot].icon.gameObject.SetActive(true);
        list[selectedSlot].icon.sprite = Resources.Load<Sprite>(iconName);        
        moveIcon.sprite = null;
        moveIcon.gameObject.SetActive(false);
    }
    public void OnBeginDrag(PointerEventData _eventdata)
    {
        //moveIcon.transform.position = _eventdata.position;        
    }
    public void OnDrag(PointerEventData _eventdata)
    {
        moveIcon.transform.position = _eventdata.position;
        iconName = moveIcon.sprite.name;
    }
    public void OnEndDrag(PointerEventData _eventdata)
    {
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i].IsInRect(_eventdata.position))
            {
                dropSlot = i;
                string str = list[dropSlot].icon.name;
                if (list[dropSlot].icon.gameObject.activeSelf == false)
                {
                    list[dropSlot].icon.gameObject.SetActive(true);
                    list[dropSlot].icon.sprite = Resources.Load<Sprite>(iconName);
                    moveIcon.gameObject.SetActive(false);
                }
                else if (list[dropSlot].icon.gameObject.activeSelf == true &&
                    list[dropSlot].icon.sprite.name != moveIcon.sprite.name)
                {                    
                    list[dropSlot].icon.sprite = Resources.Load<Sprite>(iconName);
                    list[selectedSlot].icon.sprite = Resources.Load<Sprite>(str);
                    moveIcon.gameObject.SetActive(false);
                }
            }
            else if (!list[i].IsInRect(_eventdata.position))
            {
                list[selectedSlot].icon.gameObject.SetActive(true);
                list[selectedSlot].icon.sprite = Resources.Load<Sprite>(iconName);
                moveIcon.gameObject.SetActive(false);
            }
        }
        
    }
    void Update()
    {
        
    }
}
