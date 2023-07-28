
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static bool Paused = false;
    public GameObject PauseMenuCanvas;
    //public string LoadScene;

    public GameObject Player;

    [SerializeField]
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f; //시간 스케일이 1인 경우, 정상적인 시간 흐름
    }

    // Update is called once per frame
    void Update()
    {
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
    void Stop()
    {
        PauseMenuCanvas.SetActive(true); //정지캔버스 불러오기
        Time.timeScale = 0f; //시간 스케일이 0인 경우, 정지
        Paused = true; //상태: 정지가 참임
    }

    public void Play()
    {
        PauseMenuCanvas.SetActive(false); //정지캔버스 반대로 내보내기
        Time.timeScale = 1f;
        Paused = false; //상태: 정지가 거짓임
    }

    public void MainmenuButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    //저장 함수
    //public void GameSave()
    //{
    //    //플레이어 정보(위치,체력 등)
    //    PlayerPrefs.Set
    //    //아이템 정보(개수)

    //}
}
