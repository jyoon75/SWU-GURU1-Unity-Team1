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
        questList.Add(10, new QuestData("���� ����Ʈ", new int[] { }));
    }

    public int GetQuestTalkIndex(int id)
    {
        return questId;
    }
    */
    /*
    public GameObject questPanel; // ����Ʈ â
    public GameObject QuestHolder; // ����Ʈ ����ִ� ����
    public TextMeshProUGUI[] quests; // ����Ʈ ���� ����

    [Header("Quest_Data")]
    public Dictionary<int, QuestData> QuestList; // ������ �迭�� Ű ������ �����Ͽ� �з� (����Ʈ ���)

    public QuestData[] qData;
    public QuestGoal goal;

    private void Awake()
    {
        // ���� ���� ������ ���Ե� ä���
        quests = QuestHolder.GetComponentsInChildren<TextMeshProUGUI>();

        QuestList = new Dictionary<int, QuestData>();

        // ����Ʈ �߰�
        goal = new QuestGoal();
        qData[0].goal.goalType = QuestGoal.GoalType.GatheringItem;
        qData[0].setData("Cube ȹ���ϱ�", goal);



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
