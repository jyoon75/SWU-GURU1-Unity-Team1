using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRotate : MonoBehaviour
{
    public float rotSpeed = 200f; // ȸ�� �ӵ� ����

    // ȸ�� �� ����
    float mx = 0;
    float my = 0;

    public ActionManager actionManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(actionManager.playerAction)
        {
            // ���콺 �Է� �޾� ������ ����
            float mouse_X = Input.GetAxis("Mouse X");
            float mouse_Y = Input.GetAxis("Mouse Y");

            // ȸ�� �� ������ ���콺 �Է°� �̸� ����
            mx += mouse_X * rotSpeed * Time.deltaTime;
            my += mouse_Y * rotSpeed * Time.deltaTime;

            // ���콺 ���� �̵� ȸ�� ������ �� -90�� ~ 90�� ���̷� ����
            my = Mathf.Clamp(my, -90f, 90f);
            // ȸ�� �������� ��ü ȸ��
            transform.eulerAngles = new Vector3(-my, mx, 0);
        }
    }
}
