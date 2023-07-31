using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.UIElements;

public class DayNightController : MonoBehaviour
{
    public static DayNightController instance;
    public DayNightController dayNightController;
    public LayerMask objectLayerMask;
    public float range = 3f; //ħ�� Ŭ���� ������ �Ÿ��� ���� ����

    public Light sunLight; // ���� �㿡 ���� ������ ������ ����Ʈ ������Ʈ

    public float timerDuration = 300f; // 5�� Ÿ�̸��� ���� �ð� (�� ����)
    public float currentTime; // ���� (��)Ÿ�̸��� ��� �ð�
    public float day_currentTime; //�� Ÿ�̸��� ��� �ð�
    public float remainTime; //�㿡�� ������ ���� �ð�
    public int min; //��
    public int sec; //��
    public int day_sec; //(��)��

    public int Day = 1; //N����
    public bool isNight = false;

    public static bool Paused = false;

    //public GameObject TimerText;
    //public GameObject TimerCountText;

    void Awake()
    {
        //if(dayNightController != null)
        //{
            DayNightController.instance = this;
        //}
    }
    private void Start()
    {
        Day = 1;
        isNight = false;
        currentTime = 0f; // Ÿ�̸� ���� �ð��� 0���� �ʱ�ȭ
        day_currentTime = 0f; //�� Ÿ�̸ӵ�
    }

    private void Update()
    {

        if(isNight)//�� ����
        {
            // Ÿ�̸Ӱ� �۵� ������ Ȯ���ϰ� ��� �ð��� ����
            if (currentTime < timerDuration)
            {
                currentTime += 1 * Time.deltaTime;
                remainTime = timerDuration - currentTime;
                min = Mathf.FloorToInt(remainTime / 60); //�� ǥ��
                sec = Mathf.FloorToInt(remainTime % 60); //�� ǥ��

                //�Ʒ� ������ ����׿� �ڵ�
                //Debug.Log(currentTime);
                //Debug.Log(timerDuration);
                //Debug.Log(remainTime);
                Debug.Log(min+"��"+sec+"��");

                // Ÿ�̸Ӱ� ������ �� ������ ���� �ۼ�
                if (min == 0 && sec == 0)
                {
                    OnTimerEnd();

                    day_currentTime += Time.deltaTime;
                    day_sec = Mathf.CeilToInt(remainTime % 60); //(��)�� ǥ��

                    print("���� ��:" + day_sec);
                }
            }

        }

        // ������ ������ �����Ͽ� �ð��� ���� ��⸦ ��ȭ��ŵ�ϴ�.
        float lightIntensity = isNight ? 0.15f : 1f;
        sunLight.intensity = lightIntensity;
    }

    public void ToggleDayNight()
    {
        if (!isNight) //���� ���� ������ ���
        {
            isNight = !isNight; // �� -> ��
            currentTime = 0f; //�̸� �� Ÿ�̸� �ʱ�ȭ
            /*
            if(Input.GetKeyUp(KeyCode.Escape))
            {
                if (Paused)
                {
                    GameManager.instance.Play();
                }
                else
                {
                    GameManager.instance.Stop();
                }
            }
            */

        }
    }

    private void OnTimerEnd() //��->��
    {
        isNight = !isNight; // Ÿ�̸Ӱ� ������ ��, �㿡�� ������ ���
        Day++; // N+1 ����

        //day_currentTime += Time.deltaTime;
        //day_sec = Mathf.CeilToInt(remainTime % 60); //(��)�� ǥ��

        //print("���� ��:"+day_sec);

        //�����ϱ�
    }

}

