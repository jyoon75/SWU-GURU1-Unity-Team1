using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//씬매니지먼트
public class MainMenu : MonoBehaviour
{
    public string LoadScene;

    public void Play() //플레이 버튼 클릭 시 게임씬으로 이동
    {
        SceneManager.LoadScene("GameScene");
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("게임을 종료합니다"); //게임 종료 시, 콘솔창에 종료 문구 출력
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
