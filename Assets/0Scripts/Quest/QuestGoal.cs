using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestGoal
{
    public enum GoalType // 퀘스트 목표 유형
    {
        GatheringItem = 10,
    }
    public GoalType goalType;

    public int CurrentAmout; // 현재 값
    public int RequireAmount; // 필요 값

    public bool IsReached() // 각 퀘스트 타입 별 달성 조건
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
