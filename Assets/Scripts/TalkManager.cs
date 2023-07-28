using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TalkManager : MonoBehaviour
{
    public GameObject talkPanel;            // ��ȭ â
    public TextMeshProUGUI talkText;        // ��ȭ �ؽ�Ʈ
    public GameObject contectCharactor;     // ��ȭ ���
    public int talkIndex = 0;               // ��� �ε���

    Dictionary<string, string[]> talkData;  // ��ȭ ����� ��ųʸ�
    public bool isTalk = false;             // ��ȭ Ȯ�ο�

    // Start is called before the first frame update
    void Start()
    {
        talkData = new Dictionary<string, string[]>();
        AddData();      // ��ųʸ��� ��ȭ �߰��ϱ�
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void AddData()
    {
        // ��ȭ �߰� ("ĳ���� ������Ʈ �̸�", new  string[] {"��� 0", "��� 1", "��� 2"})
        talkData.Add("ProtoFriend", new string[] { "�ȳ�", "�ȳ�2" });
    }

    // ��ȭ ����
    public void Talk(string name)
    {
        if (talkIndex == talkData[name].Length)
        {
            talkPanel.SetActive(false);
            isTalk = false;
            talkIndex = 0;
            return;
        }
        else
        {
            talkPanel.SetActive(true);
            talkText.text = talkData[name][talkIndex];
            isTalk = true;
            talkIndex++;
        }
    }
}
