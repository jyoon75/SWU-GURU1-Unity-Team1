using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public int questId;
    Dictionary<int, QuestData> questList;

    private void Awake()
    {
        questList = new Dictionary<int, QuestData>();
        GenerateData();
    }

    private void GenerateData()
    {
        questList.Add(10, new QuestData("¿¹½Ã Äù½ºÆ®", new int[] { }));
    }

    public int GetQuestTalkIndex(int id)
    {
        return questId;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
