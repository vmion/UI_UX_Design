using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public delegate void Do();

public class _8_Slot : MonoBehaviour
{
    public Image icon;
    public Image cool;
    int skillIndex;
    Do doSkill;
    bool bSkillStart;
    public float elapsed;
    float tmpElapsed;
    void Start()
    {
        bSkillStart = false;
        tmpElapsed = elapsed;
    }
    public void SetSlotSkill(Do _skill)
    {
        doSkill = _skill;
    }
    public void SkillSelect()
    {
        if (bSkillStart == false)
        {
            bSkillStart = true;
            Debug.Log("SkillSelect");
            cool.gameObject.SetActive(true);
            doSkill = SkillManager.instance.skillAction[1000];
        }
    }
    void Update()
    {
        if (doSkill != null && bSkillStart == true)
        {
            doSkill();
            tmpElapsed -= Time.deltaTime;
            cool.fillAmount = tmpElapsed / elapsed;
            if(cool.fillAmount <= 0f)
            {
                cool.gameObject.SetActive(false);
                cool.fillAmount = 1f;
                bSkillStart = false;
                tmpElapsed = elapsed;
            }
        }
    }
}
