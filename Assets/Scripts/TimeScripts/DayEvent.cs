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
        F1.SetActive(false);
        F2.SetActive(false);
        F3.SetActive(false);
        F4.SetActive(false);
        F5.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //public int EventDay = DayNightController.instance.Day;

        if ( DayNightController.instance.Day == 2 ) //동료 모집
        {
            
            print("2일차 이벤트 디버깅");
        }

        else if (DayNightController.instance.Day == 3)
        {
            print("3일차 이벤트 디버깅");
        }

        else if (DayNightController.instance.Day == 4)
        {
            print("4일차 이벤트 디버깅");
        }

        else if ( DayNightController.instance.Day == 5 )
        {
            print("5일차 이벤트 디버깅");
        }

        else if (DayNightController.instance.Day == 7)
        {
            print("7일차 이벤트 디버깅");
        }
    }
}
