using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//���Ŵ�����Ʈ
public class MainMenu : MonoBehaviour
{
    public string LoadScene;

    public void Play() //�÷��� ��ư Ŭ�� �� ���Ӿ����� �̵�
    {
        SceneManager.LoadScene("GameScene");
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("������ �����մϴ�"); //���� ���� ��, �ܼ�â�� ���� ���� ���
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
