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
    public float range = 3f; //침대 클릭이 가능한 거리에 대한 변수

    public Light sunLight; // 낮과 밤에 따라 조명을 조절할 라이트 오브젝트

    public float timerDuration = 300f; // 5분 타이머의 지속 시간 (초 단위)
    public float currentTime; // 현재 (밤)타이머의 경과 시간
    public float day_currentTime; //낮 타이머의 경과 시간
    public float remainTime; //밤에서 낮까지 남은 시간
    public int min; //분
    public int sec; //초
    public int day_sec; //(낮)초

    public int Day = 1; //N일차
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
        currentTime = 0f; // 타이머 시작 시간을 0으로 초기화
        day_currentTime = 0f; //낮 타이머도
    }

    private void Update()
    {

        if(isNight)//밤 시작
        {
            // 타이머가 작동 중인지 확인하고 경과 시간을 증가
            if (currentTime < timerDuration)
            {
                currentTime += 1 * Time.deltaTime;
                remainTime = timerDuration - currentTime;
                min = Mathf.FloorToInt(remainTime / 60); //분 표현
                sec = Mathf.FloorToInt(remainTime % 60); //분 표현

                //아래 문단은 디버그용 코드
                //Debug.Log(currentTime);
                //Debug.Log(timerDuration);
                //Debug.Log(remainTime);
                Debug.Log(min+"분"+sec+"초");

                // 타이머가 끝났을 때 수행할 동작 작성
                if (min == 0 && sec == 0)
                {
                    OnTimerEnd();

                    day_currentTime += Time.deltaTime;
                    day_sec = Mathf.CeilToInt(remainTime % 60); //(낮)초 표현

                    print("낮의 초:" + day_sec);
                }
            }

        }

        // 조명의 강도를 조절하여 시간에 따라 밝기를 변화시킵니다.
        float lightIntensity = isNight ? 0.15f : 1f;
        sunLight.intensity = lightIntensity;
    }

    public void ToggleDayNight()
    {
        if (!isNight) //낮일 때만 밤으로 토글
        {
            isNight = !isNight; // 낮 -> 밤
            currentTime = 0f; //미리 밤 타이머 초기화
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

    private void OnTimerEnd() //밤->낮
    {
        isNight = !isNight; // 타이머가 끝났을 때, 밤에서 낮으로 토글
        Day++; // N+1 일차

        //day_currentTime += Time.deltaTime;
        //day_sec = Mathf.CeilToInt(remainTime % 60); //(낮)초 표현

        //print("낮의 초:"+day_sec);

        //저장하기
    }

}

