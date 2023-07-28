using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{ 

    public enum InfoType { Day, Time, TimeCount, Health, Thirst }
    public InfoType type;

    public Text TextField;
    //Slider mySlider;

    void Awake()
    { 
        TextField = GetComponent<Text>();
        //mySlider = GetComponent<Slider>();
    }

    public void Update()
    {
        switch (type)
        {
            case InfoType.Day:
                TextField.text = string.Format("{0:F0}일차", DayNightController.instance.Day); //N일차 표현
                break;

            case InfoType.Time:
                if (DayNightController.instance.isNight)
                {
                    TextField.text = "낮까지 남은 시간:";
                }
                else
                {
                    TextField.text = " ";
                }
                break;


            case InfoType.TimeCount:
                if (DayNightController.instance.isNight)
                {
                    TextField.text = string.Format("{0:D2}:{1:D2}", DayNightController.instance.min, DayNightController.instance.sec);
                }
                else
                {
                    TextField.text = " ";
                }
                //TextField.text = "변경 후";
                break;

            case InfoType.Health:

                break;

            case InfoType.Thirst:

                break;
        }
    }
}