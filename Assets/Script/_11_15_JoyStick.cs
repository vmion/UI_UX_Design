using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class _11_15_JoyStick : MonoBehaviour
{
    public Image OutterStick;
    public Image InnerStick;
    Vector2 dir;
    Vector2 centerPos;
    float radius;
    void Start()
    {
        centerPos = OutterStick.transform.position;
        radius = OutterStick.rectTransform.rect.width * 0.5f;
    }
    public void OnPointerDown(BaseEventData _eventData)
    {
        PointerEventData eventData = (PointerEventData)_eventData;
        Debug.Log(eventData.position);
        InnerStick.transform.position = eventData.position;
    }
    public void OnPointerUp(BaseEventData _eventData)
    {
        PointerEventData eventData = (PointerEventData)_eventData;
        Debug.Log("¶¿¶§ À§Ä¡ = " + eventData.position);
        InnerStick.transform.position = centerPos;
    }
    public void OnBeginDrag(BaseEventData _eventData)
    {
        PointerEventData eventData = (PointerEventData)_eventData;
        InnerStick.transform.position = eventData.position;
    }
    public void OnDrag(BaseEventData _eventData)
    {
        PointerEventData eventData = (PointerEventData)_eventData;
        Debug.Log(eventData.position);
        float distance = Vector2.Distance(centerPos, eventData.position);
        if (distance > radius)
        {
            dir = (Vector2)eventData.position - centerPos;
            InnerStick.transform.position = centerPos + dir.normalized * radius * 0.5f;
        }
        else
        {
            InnerStick.transform.position = eventData.position;
        }
    }

    public void OnEndDrag(BaseEventData _eventData)
    {
        InnerStick.transform.position = centerPos;
    }
    void Update()
    {
        
    }
}
