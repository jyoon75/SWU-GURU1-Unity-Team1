using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TalkManager : MonoBehaviour
{
    public GameObject talkPanel;            // 대화 창
    public TextMeshProUGUI talkText;        // 대화 텍스트
    public GameObject contectCharactor;     // 대화 상대
    public int talkIndex = 0;               // 대사 인덱스

    Dictionary<string, string[]> talkData;  // 대화 저장용 딕셔너리
    public bool isTalk = false;             // 대화 확인용

    // Start is called before the first frame update
    void Start()
    {
        talkData = new Dictionary<string, string[]>();
        AddData();      // 딕셔너리에 대화 추가하기
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void AddData()
    {
        // 대화 추가 ("캐릭터 오브젝트 이름", new  string[] {"대사 0", "대사 1", "대사 2"})
        talkData.Add("ProtoFriend", new string[] { "안녕", "안녕2" });
    }

    // 대화 진행
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
