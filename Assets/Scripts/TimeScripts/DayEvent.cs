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

        if ( DayNightController.instance.Day == 1 ) //���� ����
        {
            F1.SetActive(true);
            print("2���� �̺�Ʈ �����");
        }

        else if (DayNightController.instance.Day == 2)
        {
            print("3���� �̺�Ʈ �����");
        }

        else if (DayNightController.instance.Day == 3)
        {
            print("3���� �̺�Ʈ �����");
        }

        else if (DayNightController.instance.Day == 4)
        {
            print("4���� �̺�Ʈ �����");
        }

        else if ( DayNightController.instance.Day == 5 )
        {
            print("5���� �̺�Ʈ �����");
        }

        else if (DayNightController.instance.Day == 6)
        {
            print("5���� �̺�Ʈ �����");
        }

        else if (DayNightController.instance.Day == 7)
        {
            print("7���� �̺�Ʈ �����");
        }
        else
        {
            print("���ǿ���");
        }
    }
}
