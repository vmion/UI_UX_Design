using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _11_08_Image : MonoBehaviour
{
    public Image hp;
    public Sprite Ch_Image;
    public Sprite Ch_Image2;
    public Texture2D Ch_Texture;
    public Texture2D Ch_Texture2;
    bool countI;
    bool countT;
    Image HP;
    void Start()
    {
        countI = false;
        countT = false;
        //HP.sprite = Resources.Load<Sprite>("/HP");
    }
    void Update()
    {
        Vector3 tmp = transform.position;
        tmp.y += 0.8f;
        Vector3 screenPos = Camera.main.WorldToScreenPoint(tmp);
        hp.transform.position = screenPos;

        //키보드 F1키를 눌렀을 경우
        //UI hp의 이미지를 변경(변경하는 이미지의 이름은 Mp.png)
        if(Input.GetKeyDown(KeyCode.F1))
        {
            //hp.sprite = Resources.Load<Sprite>("Mp");
            if(countI == false)
            {
                hp.sprite = Ch_Image;
                countI = true;
            }
            else
            {
                hp.sprite = Ch_Image2;
                countI = false;
            }
        }
        //키보드 F2키를 눌렀을 경우
        //Cube의 텍스처를 변경(변경하는 텍스처의 이름은 newCube.png)
        if (Input.GetKeyDown(KeyCode.F2))
        {
            //GetComponent<MeshRenderer>().material.mainTexture = Resources.Load<Texture2D>("newCube");  
            if (countT == false)
            {
                GetComponent<MeshRenderer>().material.mainTexture = Ch_Texture;
                countT = true;
            }
            else
            {
                GetComponent<MeshRenderer>().material.mainTexture = Ch_Texture2;
                countT = false;
            }
        }
    }
}
