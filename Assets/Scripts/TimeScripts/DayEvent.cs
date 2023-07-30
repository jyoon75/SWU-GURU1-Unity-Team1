using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayEvent : MonoBehaviour
{

    public int EventDay = DayNightController.instance.Day;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //public int EventDay = DayNightController.instance.Day;

        switch (EventDay)
        {
            case 1:
                break;

            case 2:
                print("2일차 이벤트 디버깅");
                //이벤트 씬 넘기기
                break;

            case 3:
                break;

            case 4:
                break;

            case 5:
                print("5일차 이벤트 디버깅");
                break;

            case 6:
                break;

            case 7:
                print("7일차 결말 디버깅");
                //결말 씬 넘기기
                break;

        }
    }
}
