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
                TextField.text = string.Format("{0:F0}����", DayNightController.instance.Day); //N���� ǥ��
                break;

            case InfoType.Time:
                if (DayNightController.instance.isNight)
                {
                    TextField.text = "������ ���� �ð�:";
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
                //TextField.text = "���� ��";
                break;

            case InfoType.Health:

                break;

            case InfoType.Thirst:

                break;
        }
    }
}