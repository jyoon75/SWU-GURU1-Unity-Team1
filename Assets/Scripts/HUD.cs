using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//������: UI�� ���� ��ũ��Ʈ
public class HUD : MonoBehaviour
{
    //������ public �ӽ� ����
    int cur_hp = 60; //�ǽð� ü�� ����
    int max_hp = 100; //�ִ� ü��

    int cur_thr = 20; //�ǽð� ���� ����
    int max_thr = 100; //�ִ� ����
    //���߿� �ٸ� ��ũ��Ʈ���� �޾ƿ� ������ �޾ƿ��� �� ������ ���� ���� ����!

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

            case InfoType.HealthSlider:
                mySlider.value = (float) cur_hp / max_hp;
                break;

            case InfoType.HpCountText:
                //�ٸ� ��ũ��Ʈ�� ������ ��������. �Ʒ��� ����
                //float curHp = �ٸ���ũ��Ʈ��.instance.hp;
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