
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public static bool Paused = false;
    public GameObject PauseMenuCanvas;
    public GameObject UICanvas;

    void Awake()
    {
        GameManager.instance = this;
    }

    [SerializeField]
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1; //시간 스케일이 1인 경우, 정상적인 시간 흐름
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerMove.instance.cur_hp <= 0) 
        {
            SceneManager.LoadScene(2);
        }


        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (Paused)
            {
                Play(); //40열부터 플레이 함수 정의
            }
            else
            {
                Stop(); //33열부터 스톱 함수 정의
            }
        }
    }
    public void Stop()
    {
        print("정지씬");
        PauseMenuCanvas.SetActive(true);
        UICanvas.SetActive(false);
        Cursor.lockState = CursorLockMode.None; // 마우스 커서를 화면 중앙 고정 해제
        Time.timeScale = 0f; //시간 스케일이 0인 경우, 정지
        Paused = true; //상태: 정지가 참임
    }

    public void Play()
    {
        print("게임씬");
        PauseMenuCanvas.SetActive(false);
        UICanvas.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked; // 마우스 커서를 화면 중앙에 고정
        Time.timeScale = 1f;
        Paused = false;
        //SceneManager.LoadScene("GameScene");
    }

    public void MainmenuButton()
    {
        print("메인메뉴씬");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
        SceneManager.LoadScene(0);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    //저장 함수
    //public void GameSave()
    //{
    //    //플레이어 정보(위치,체력 등)
    //    PlayerPrefs.Set
    //    //아이템 정보(개수)

    //}
}
