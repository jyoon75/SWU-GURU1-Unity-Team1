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
    
    public GameObject questPanel; // 퀘스트 창
    public GameObject QuestHolder; // 퀘스트 들어있는 공간
    public TextMeshProUGUI[] quests; // 퀘스트 모음 변수

    [Header("Quest_Data")]
    public Dictionary<int, QuestData> QuestList; // 데이터 배열을 키 값으로 구분하여 분류 (퀘스트 목록)

    public QuestData[] qData = new QuestData[10];
    public QuestGoal goal;

    public DayNightController dayNightController;

    private void Start()
    {
        // 슬롯 모음 변수에 슬롯들 채우기
        quests = QuestHolder.GetComponentsInChildren<TextMeshProUGUI>();
        
        QuestList = new Dictionary<int, QuestData>();

        // 퀘스트 추가
        goal = new QuestGoal();
        qData[0].goal.goalType = QuestGoal.GoalType.GatheringItem;
        //qData[0].setData("Cube 획득하기", goal);
        qData[0] = (new QuestData());

        QuestList.Add(1, new QuestData("셸터 수리를 위한 목재 획득하기", goal.goalType));
        /*
        goal = new QuestGoal();
        qData[1].goal.goalType = QuestGoal.GoalType.GatheringItem;
        qData[1].setData("셸터 수리를 위한 목재 획득하기", goal);


        QuestList.Add(0, qData[0]);


    }
    void Update()
    {
        if (dayNightController.Day == 1)
        {
            QuestList.Add(1, qData[1]);
        }
        for (int i = 0; i < quests.Length; i++)
        {
            quests[i].text = QuestList[i].questName;
        }
        */
    }

}
