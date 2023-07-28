using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestData
{
    public bool isQuesting; // 퀘스트 진행
    public string questName; // 퀘스트 이름

    public QuestGoal goal; // 퀘스트 목표

    //public string description; //설명
    //public string reward; //보상     

    public void setData(string questName, QuestGoal goal) // 퀘스트 데이터 초기화 
    {
        isQuesting = true;
        this.questName = questName;
        //this.description = description;
        //this.reward = reward;
        this.goal = goal;
    }

    public void Complete()
    {
        Debug.Log("미션 완료");
    }
}
