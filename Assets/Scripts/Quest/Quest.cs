using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class Quest : MonoBehaviour
{
    public DayNightController dayNightController;
    public Inventory inventory;

    // 퀘스트1
    public string quest1Name; // 퀘스트 이름
    public string quest1NeedItem; // 퀘스트 필요 아이템
    public int quest1CurrentAmout = 0; // 퀘스트 현재 값
    public int quest1RequireAmount; // 퀘스트 필요 값
    public bool quest1isQuesting = true; // 퀘스트 진행 중

    // 퀘스트2
    public string quest2Name; // 퀘스트 이름
    public string quest2NeedItem; // 퀘스트 필요 아이템
    public int quest2CurrentAmout = 0; // 퀘스트 현재 값
    public int quest2RequireAmount; // 퀘스트 필요 값
    public bool quest2isQuesting = true; // 퀘스트 진행 중

    // 퀘스트3
    public string quest3Name; // 퀘스트 이름
    public string quest3NeedItem; // 퀘스트 필요 아이템
    public int quest3CurrentAmout = 0; // 퀘스트 현재 값
    public int quest3RequireAmount; // 퀘스트 필요 값
    public bool quest3isQuesting = true; // 퀘스트 진행 중

    public GameObject questPanel; // 퀘스트 창
    //public GameObject QuestHolder; // 퀘스트 들어있는 공간
    //public TextMeshProUGUI[] quests; // 퀘스트 모음 변수

    public TextMeshProUGUI questText1;
    public TextMeshProUGUI questText2;
    public TextMeshProUGUI questText3;

    //public QuestData[] qData = new QuestData[3];


    // Start is called before the first frame update
    void Start()
    {
        // 슬롯 모음 변수에 슬롯들 채우기
        //quests = QuestHolder.GetComponentsInChildren<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (dayNightController.Day == 1)
        {
            Day1Quest();
        }
        if (dayNightController.Day == 2)
        {
            Day2Quest();
        }
        if (dayNightController.Day == 3)
        {
            Day3Quest();
        }
        if (dayNightController.Day == 4)
        {
            Day4Quest();
        }
        if (dayNightController.Day == 5)
        {
            Day5Quest();
        }
        if (dayNightController.Day == 6)
        {
            Day6Quest();
        }
        if (dayNightController.Day == 7)
        {
            Day7Quest();
        }

        if (dayNightController.isNight)
        {
            questPanel.SetActive(false);
        }
        else
        {
            questPanel.SetActive(true);
        }


    }

    private void ClearCheck()
    {
        if (quest1CurrentAmout >= quest1RequireAmount)
        {
            questText1.color = Color.yellow;
            quest1isQuesting = false;
            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.slots[i].item != null)
                {
                    if (inventory.slots[i].item.itemName == quest1NeedItem)
                    {
                        inventory.slots[i].itemCount =- quest1RequireAmount;
                    }
                }
            }
            quest1CurrentAmout = 0;
        }
    }

    private void Questing1()
    {
        if (quest1isQuesting)
        {
            // 퀘스트창에 띄우기
            questText1.text = quest1Name + " (" + quest1CurrentAmout + "/" + quest1RequireAmount + ")";

            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.slots[i].item != null)
                {
                    if (inventory.slots[i].item.itemName == quest1NeedItem)
                    {
                        quest1CurrentAmout = inventory.slots[i].itemCount;

                        questText1.color = Color.white;
                        questText1.text = quest1Name + " (" + quest1CurrentAmout + "/" + quest1RequireAmount + ")";
                    }
                }
            }
            // 클리어
            ClearCheck();
        }
    }
    private void Questing2()
    {
        if (quest2isQuesting)
        {
            // 퀘스트창에 띄우기
            questText2.text = quest2Name;

            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.slots[i].item != null)
                {
                    if (inventory.slots[i].item.itemName == quest2NeedItem)
                    {
                        quest2CurrentAmout = inventory.slots[i].itemCount;

                        questText2.color = Color.white;
                        questText2.text = quest2Name;
                    }
                }
            }
            // 클리어
            ClearCheck();
        }
    }
    private void Questing3()
    {
        if (quest3isQuesting)
        {
            // 퀘스트창에 띄우기
            questText3.text = quest3Name;

            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.slots[i].item != null)
                {
                    if (inventory.slots[i].item.itemName == quest3NeedItem)
                    {
                        quest3CurrentAmout = inventory.slots[i].itemCount;

                        questText3.color = Color.white;
                        questText3.text = quest3Name;
                    }
                }
            }
            // 클리어
            ClearCheck();
        }
    }

    private void Day1Quest()
    {
        // 퀘스트 설정
        quest1Name = "목재 모으기";
        quest1NeedItem = "Wood";
        quest1RequireAmount = 3;

        quest2Name = "함께 싸울 동료 찾기";

        // 퀘스트 진행
        Questing1();
        Questing2();
    }

    private void Day2Quest()
    {
        // 퀘스트 설정
        quest1Name = "목재 모으기";
        quest1NeedItem = "Wood";
        quest1RequireAmount = 5;

        quest2Name = "함께 싸울 동료 찾기";

        quest3Name = "식량 찾아 체력 회복하기";

        // 퀘스트 진행
        Questing1();
        Questing2();
        Questing3();
    }

    private void Day3Quest()
    {
        // 퀘스트 설정
        quest1Name = "석재 모으기";
        quest1NeedItem = "Rock";
        quest1RequireAmount = 5;

        quest2Name = "함께 싸울 동료 찾기";

        quest3Name = "치료팩 찾아 동료 치료하기";

        // 퀘스트 진행
        Questing1();
        Questing2();
        Questing3();
    }

    private void Day4Quest()
    {
        // 퀘스트 설정
        quest1Name = "목재 모으기";
        quest1NeedItem = "Wood";
        quest1RequireAmount = 7;

        quest2Name = "함께 싸울 동료 찾기";

        // 퀘스트 진행
        Questing1();
        Questing2();
    }

    private void Day5Quest()
    {
        // 퀘스트 설정
        quest1Name = "비축 식량 모으기";
        quest1NeedItem = "Can";
        quest1RequireAmount = 3;

        // 퀘스트 진행
        Questing1();
    }

    private void Day6Quest()
    {
        // 퀘스트 설정
        quest1Name = "목재 모으기";
        quest1NeedItem = "Wood";
        quest1RequireAmount = 10;

        // 퀘스트 진행
        Questing1();
    }

    private void Day7Quest()
    {
        // 퀘스트 설정
        quest1Name = "석재 모으기";
        quest1NeedItem = "Rock";
        quest1RequireAmount = 10;

        // 퀘스트 진행
        Questing1();
    }

    /*
        qData[0].questName = "큐브 모으기";
        qData[0].RequireAmount = 2;
        //quests[0].text = qData[0].questName + "(" + qData[0].CurrentAmout + "/" + qData[0].RequireAmount  + ")";
        print(qData[0].questName + "(" + qData[0].CurrentAmout + "/" + qData[0].RequireAmount + ")");

        // 퀘스트 진행
        if (qData[0].isQuesting)
        {
            
            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.slots[i].item != null)
                {
                    if (inventory.slots[i].item.itemName == qData[0].questName)
                    {
                        qData[0].CurrentAmout = inventory.slots[i].itemCount;
                        //quests[0].text = qData[0].questName + "(" + qData[0].CurrentAmout + "/" + qData[0].RequireAmount + ")";
                        print(qData[0].questName + "(" + qData[0].CurrentAmout + "/" + qData[0].RequireAmount + ")");
                        return;
                    }
                }
            }
            
            // 클리어
            if (qData[0].CurrentAmout >= qData[0].RequireAmount)
            {
                qData[0].isQuesting = false;
            }
        }
        */
}