using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class _11_15_UICollisionTest : MonoBehaviour
{
    public Image moveIcon;
    public Image[] arrTarget;
    int[] targetAmount;
    Vector3 startPos;
    void Start()
    {
        targetAmount = new int[4];
        startPos = moveIcon.transform.position;
    }
    public void OnDrag(BaseEventData _eventData)
    {
        moveIcon.transform.position = ((PointerEventData)_eventData).position;
    }
    public void OnEndDrag(BaseEventData _eventData)
    {
        PointerEventData eventData = (PointerEventData)_eventData;
        for (int i = 0; i < arrTarget.Length; i++)
        {
            float xMin = arrTarget[i].transform.position.x - arrTarget[0].rectTransform.rect.width * 0.5f;
            float xMax = arrTarget[i].transform.position.x + arrTarget[0].rectTransform.rect.width * 0.5f;
            float yMin = arrTarget[i].transform.position.y - arrTarget[0].rectTransform.rect.height * 0.5f;
            float yMax = arrTarget[i].transform.position.y + arrTarget[0].rectTransform.rect.height * 0.5f;

            if(eventData.position.x >= xMin && eventData.position.x <= xMax &&
                eventData.position.y >= yMin && eventData.position.y <= yMax)
            {
                Color color = arrTarget[i].color;
                color.r = Random.Range(0, 1f);
                color.g = Random.Range(0, 1f);
                color.b = Random.Range(0, 1f);
                arrTarget[i].color = color;
                Text amout = arrTarget[i].gameObject.GetComponentInChildren<Text>();
                amout.text = (++targetAmount[i]).ToString();
            }
        }
        moveIcon.transform.position = startPos;
    }
    void Update()
    {
        
    }
}
