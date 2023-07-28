using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionManager : MonoBehaviour
{
    // 싱글톤 변수
    public static ActionManager gm;
    private void Awake()
    {
        if (gm == null)
            gm = this;
    }

    public bool playerAction;   // false면 이동, 시야 회전 못 함
    public TalkManager talkManager;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (talkManager.isTalk == true || GameManager.Paused == true)
        {
            playerAction = false;
        }
        else
        {
            playerAction = true;
        }
    }
}
