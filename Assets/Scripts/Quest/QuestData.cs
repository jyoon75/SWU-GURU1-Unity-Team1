using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestData
{
    public bool isQuesting; // ����Ʈ ����
    public string questName; // ����Ʈ �̸�

    public QuestGoal goal; // ����Ʈ ��ǥ

    //public string description; //����
    //public string reward; //����     

    public void setData(string questName, QuestGoal goal) // ����Ʈ ������ �ʱ�ȭ 
    {
        isQuesting = true;
        this.questName = questName;
        //this.description = description;
        //this.reward = reward;
        this.goal = goal;
    }

    public void Complete()
    {
        Debug.Log("�̼� �Ϸ�");
    }
}
