
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
        Time.timeScale = 1; //�ð� �������� 1�� ���, �������� �ð� �帧
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
                Play(); //40������ �÷��� �Լ� ����
            }
            else
            {
                Stop(); //33������ ���� �Լ� ����
            }
        }
    }
    public void Stop()
    {
        print("������");
        PauseMenuCanvas.SetActive(true);
        UICanvas.SetActive(false);
        Cursor.lockState = CursorLockMode.None; // ���콺 Ŀ���� ȭ�� �߾� ���� ����
        Time.timeScale = 0f; //�ð� �������� 0�� ���, ����
        Paused = true; //����: ������ ����
    }

    public void Play()
    {
        print("���Ӿ�");
        PauseMenuCanvas.SetActive(false);
        UICanvas.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked; // ���콺 Ŀ���� ȭ�� �߾ӿ� ����
        Time.timeScale = 1f;
        Paused = false;
        //SceneManager.LoadScene("GameScene");
    }

    public void MainmenuButton()
    {
        print("���θ޴���");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
        SceneManager.LoadScene(0);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    //���� �Լ�
    //public void GameSave()
    //{
    //    //�÷��̾� ����(��ġ,ü�� ��)
    //    PlayerPrefs.Set
    //    //������ ����(����)

    //}
}
