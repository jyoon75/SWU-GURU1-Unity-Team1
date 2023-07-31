using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestGoal
{
    public enum GoalType // ����Ʈ ��ǥ ����
    {
        GatheringItem = 10,
    }
    public GoalType goalType;

    public int CurrentAmout; // ���� ��
    public int RequireAmount; // �ʿ� ��

    public bool IsReached() // �� ����Ʈ Ÿ�� �� �޼� ����
    {
        if (goalType == GoalType.GatheringItem)
        {
            return CurrentAmout >= RequireAmount;
        }
        else
        {
            return false;
        }
    }


}
