using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayEvent : MonoBehaviour
{
    public GameObject F1;
    public GameObject F2;
    public GameObject F3;
    public GameObject F4;
    public GameObject F5;

    // Start is called before the first frame update
    void Start()
    {
        DayNightController.instance.Day = 1;
        //F1.SetActive(false);
        //F2.SetActive(false);
        //F3.SetActive(false);
        //F4.SetActive(false);
        //F5.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //public int EventDay = DayNightController.instance.Day;

        if ( DayNightController.instance.Day == 1 ) //동료 모집
        {
            F1.SetActive(true);
            print(DayNightController.instance.Day+"일차 이벤트 디버깅");
        }

        else if (DayNightController.instance.Day == 2)
        {
            print(DayNightController.instance.Day+"일차 이벤트 디버깅");
        }

        else if (DayNightController.instance.Day == 3)
        {
            print(DayNightController.instance.Day + "일차 이벤트 디버깅");
        }

        else if (DayNightController.instance.Day == 4)
        {
            print(DayNightController.instance.Day + "일차 이벤트 디버깅");
        }

        else if ( DayNightController.instance.Day == 5 )
        {
            print(DayNightController.instance.Day + "일차 이벤트 디버깅");
        }

        else if (DayNightController.instance.Day == 6)
        {
            print(DayNightController.instance.Day + "일차 이벤트 디버깅");
        }

        else if (DayNightController.instance.Day == 7)
        {
            print(DayNightController.instance.Day + "일차 이벤트 디버깅");
        }
        else
        {
            print("해피엔딩");
        }
    }
}
