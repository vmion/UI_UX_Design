using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillManager : MonoBehaviour
{
    public static SkillManager instance;
    public Dictionary<int, Do> skillAction;
    Do doSomthing;
    _8_Skill_A skillA;
    _8_Skill_B skillB;
    _8_Skill_C skillC;
    _8_Skill_D skillD;
    _8_Skill_E skillE;
    // 스킬 테이블의 내용을 알고있으며 사용자에게 스킬을 할당
    void Awake()
    {
        instance = this;
        skillA = new _8_Skill_A();
        skillB = new _8_Skill_B();
        skillC = new _8_Skill_C();
        skillD = new _8_Skill_D();
        skillE = new _8_Skill_E();
    }
    void Start()
    {
        // 어느 스킬이 어느 클래스인가?
        skillAction = new Dictionary<int, Do>();
        skillAction.Add(1000, SkillFunction(1000));
        skillAction.Add(1002, SkillFunction(1002));
        skillAction.Add(1001, SkillFunction(1001));
        skillAction.Add(1003, SkillFunction(1003));
        skillAction.Add(1005, SkillFunction(1005));
        skillAction.Add(1004, SkillFunction(1004));
    }
    public Do SkillFunction(int _index)
    {
        Do tmp = null;
        switch(_index)
        {
            case 1000:
                {
                    tmp = skillA.SpeeUp;
                }
                break;
            case 1001:
                {
                    tmp = skillA.SpeeUp;
                }
                break;
        }
        return tmp;
    }
    
    void Update()
    {
        
    }
}
