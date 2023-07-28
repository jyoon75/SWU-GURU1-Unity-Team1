using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuestManager : MonoBehaviour
{
    /*
    public int questId;
    Dictionary<int, QuestData> questList;

    private void Awake()
    {
        questList = new Dictionary<int, QuestData>();
        GenerateData();
    }

    private void GenerateData()
    {
        questList.Add(10, new QuestData("예시 퀘스트", new int[] { }));
    }

    public int GetQuestTalkIndex(int id)
    {
        return questId;
    }
    */
    /*
    public GameObject questPanel; // 퀘스트 창
    public GameObject QuestHolder; // 퀘스트 들어있는 공간
    public TextMeshProUGUI[] quests; // 퀘스트 모음 변수

    [Header("Quest_Data")]
    public Dictionary<int, QuestData> QuestList; // 데이터 배열을 키 값으로 구분하여 분류 (퀘스트 목록)

    public QuestData[] qData;
    public QuestGoal goal;

    private void Awake()
    {
        // 슬롯 모음 변수에 슬롯들 채우기
        quests = QuestHolder.GetComponentsInChildren<TextMeshProUGUI>();

        QuestList = new Dictionary<int, QuestData>();

        // 퀘스트 추가
        goal = new QuestGoal();
        qData[0].goal.goalType = QuestGoal.GoalType.GatheringItem;
        qData[0].setData("Cube 획득하기", goal);



        QuestList.Add(0, qData[0]);


    }
    void Update()
    {
        for (int i = 0; i < quests.Length; i++)
        {
            quests[i].text = QuestList[i].questName;
        }

    }
    */
}
