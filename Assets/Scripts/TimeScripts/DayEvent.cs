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
                print("2���� �̺�Ʈ �����");
                //�̺�Ʈ �� �ѱ��
                break;

            case 3:
                break;

            case 4:
                break;

            case 5:
                print("5���� �̺�Ʈ �����");
                break;

            case 6:
                break;

            case 7:
                print("7���� �ḻ �����");
                //�ḻ �� �ѱ��
                break;

        }
    }
}
