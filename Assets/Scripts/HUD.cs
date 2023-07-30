using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//이혜연: UI에 대한 스크립트
public class HUD : MonoBehaviour
{
    //디버깅용 public 임시 변수
    int cur_hp = 60; //실시간 체력 변수
    int max_hp = 100; //최대 체력

    int cur_thr = 20; //실시간 갈증 변수
    int max_thr = 100; //최대 갈증
    //나중에 다른 스크립트에서 받아온 변수로 받아오면 위 변수는 전부 없앨 예정!

    public enum InfoType { Day, Time, TimeCount, HealthSlider, HpCountText, ThirstSlider, ThirstCountText }
    public InfoType type;

    public Text TextField;
    public Slider mySlider;

    void Awake()
    { 
        TextField = GetComponent<Text>();
        mySlider = GetComponent<Slider>();
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

            case InfoType.HealthSlider:
                mySlider.value = (float) cur_hp / max_hp;
                break;

            case InfoType.HpCountText:
                //다른 스크립트의 변수명 데려오기. 아래는 예시
                //float curHp = 다른스크립트명.instance.hp;
                TextField.text = cur_hp+" / " + max_hp;
                break;

            case InfoType.ThirstSlider:
                mySlider.value = (float) cur_thr / max_thr;
                break;

            case InfoType.ThirstCountText:
                TextField.text = cur_thr + " / " + max_thr;
                break;
        }
    }
}