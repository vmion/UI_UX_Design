using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.SceneManagement;

public class _11_14_TouchImage : MonoBehaviour
{
    public Image img;
    public TextMeshProUGUI desc;
    bool bAlpha;
    void Start()
    {
        InvokeRepeating("DisplayMessage", 0f, 0.3f);
    }
    public void DisplayMessage()
    {
        bAlpha = !bAlpha;
        Color tmp = desc.color;
        if (bAlpha)
        {            
            tmp.a = 0f;            
        }
        else
        {
            tmp.a = 1f;
        }
        desc.color = tmp;
    }
    public void OnClickTouchScreen(BaseEventData _eventdata)
    {
        CancelInvoke("DisplayMessage");
        SceneManager.LoadScene("3_Button", LoadSceneMode.Single);
    }
    public void OnClickImage(BaseEventData _eventData)
    {
        PointerEventData eventData = (PointerEventData)_eventData;
        Debug.Log("Å¬¸¯ÇÑ ÁÂÇ¥  = " + eventData.position);
        Debug.Log("OnClickImage");
    }
    void Update()
    {
        
    }
}
