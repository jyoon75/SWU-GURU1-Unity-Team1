
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
        Time.timeScale = 1f; //�ð� �������� 1�� ���, �������� �ð� �帧
    }

    // Update is called once per frame
    void Update()
    {
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
    void Stop()
    {
        PauseMenuCanvas.SetActive(true); //����ĵ���� �ҷ�����
        Time.timeScale = 0f; //�ð� �������� 0�� ���, ����
        Paused = true; //����: ������ ����
    }

    public void Play()
    {
        PauseMenuCanvas.SetActive(false); //����ĵ���� �ݴ�� ��������
        Time.timeScale = 1f;
        Paused = false; //����: ������ ������
    }

    public void MainmenuButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    //���� �Լ�
    //public void GameSave()
    //{
    //    //�÷��̾� ����(��ġ,ü�� ��)
    //    PlayerPrefs.Set
    //    //������ ����(����)

    //}
}
