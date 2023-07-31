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

    // ����Ʈ1
    public string quest1Name; // ����Ʈ �̸�
    public string quest1NeedItem; // ����Ʈ �ʿ� ������
    public int quest1CurrentAmout = 0; // ����Ʈ ���� ��
    public int quest1RequireAmount; // ����Ʈ �ʿ� ��
    public bool quest1isQuesting = true; // ����Ʈ ���� ��

    // ����Ʈ2
    public string quest2Name; // ����Ʈ �̸�
    public string quest2NeedItem; // ����Ʈ �ʿ� ������
    public int quest2CurrentAmout = 0; // ����Ʈ ���� ��
    public int quest2RequireAmount; // ����Ʈ �ʿ� ��
    public bool quest2isQuesting = true; // ����Ʈ ���� ��

    // ����Ʈ3
    public string quest3Name; // ����Ʈ �̸�
    public string quest3NeedItem; // ����Ʈ �ʿ� ������
    public int quest3CurrentAmout = 0; // ����Ʈ ���� ��
    public int quest3RequireAmount; // ����Ʈ �ʿ� ��
    public bool quest3isQuesting = true; // ����Ʈ ���� ��

    public GameObject questPanel; // ����Ʈ â
    //public GameObject QuestHolder; // ����Ʈ ����ִ� ����
    //public TextMeshProUGUI[] quests; // ����Ʈ ���� ����

    public TextMeshProUGUI questText1;
    public TextMeshProUGUI questText2;
    public TextMeshProUGUI questText3;

    //public QuestData[] qData = new QuestData[3];


    // Start is called before the first frame update
    void Start()
    {
        // ���� ���� ������ ���Ե� ä���
        //quests = QuestHolder.GetComponentsInChildren<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (dayNightController.Day == 1)
        {
            Day1Quest();
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
            quest1CurrentAmout = 0;
        }
    }

    private void Questing1()
    {
        if (quest1isQuesting)
        {
            // ����Ʈâ�� ����
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
            // Ŭ����
            ClearCheck();
        }
    }
    private void Questing2()
    {
        if (quest2isQuesting)
        {
            // ����Ʈâ�� ����
            questText2.text = quest2Name + " (" + quest2CurrentAmout + "/" + quest2RequireAmount + ")";

            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.slots[i].item != null)
                {
                    if (inventory.slots[i].item.itemName == quest2NeedItem)
                    {
                        quest2CurrentAmout = inventory.slots[i].itemCount;

                        questText2.color = Color.white;
                        questText2.text = quest2Name + " (" + quest2CurrentAmout + "/" + quest2RequireAmount + ")";
                    }
                }
            }
            // Ŭ����
            ClearCheck();
        }
    }
    private void Questing3()
    {
        if (quest3isQuesting)
        {
            // ����Ʈâ�� ����
            questText2.text = quest3Name + " (" + quest3CurrentAmout + "/" + quest3RequireAmount + ")";

            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.slots[i].item != null)
                {
                    if (inventory.slots[i].item.itemName == quest3NeedItem)
                    {
                        quest3CurrentAmout = inventory.slots[i].itemCount;

                        questText2.color = Color.white;
                        questText2.text = quest3Name + " (" + quest3CurrentAmout + "/" + quest3RequireAmount + ")";
                    }
                }
            }
            // Ŭ����
            ClearCheck();
        }
    }

    private void Day1Quest()
    {
        // ����Ʈ ����
        quest1Name = "ť�� ������";
        quest1NeedItem = "Cube";
        quest1RequireAmount = 2;

        // ����Ʈ ����
        Questing1();

        
    }

    private void Day2Quest()
    {
        
    }

    /*
        qData[0].questName = "ť�� ������";
        qData[0].RequireAmount = 2;
        //quests[0].text = qData[0].questName + "(" + qData[0].CurrentAmout + "/" + qData[0].RequireAmount  + ")";
        print(qData[0].questName + "(" + qData[0].CurrentAmout + "/" + qData[0].RequireAmount + ")");

        // ����Ʈ ����
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
            
            // Ŭ����
            if (qData[0].CurrentAmout >= qData[0].RequireAmount)
            {
                qData[0].isQuesting = false;
            }
        }
        */
}