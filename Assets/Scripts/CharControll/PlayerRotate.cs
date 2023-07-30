using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    public float rotSpeed = 200f;

    float mx = 0;

    public ActionManager actionManager;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (actionManager.playerAction)
        {
            // ���콺 �Է� �޾� ������ ����
            float mouse_X = Input.GetAxis("Mouse X");

            // ȸ�� �� ������ ���콺 �Է°� �̸� ����
            mx += mouse_X * rotSpeed * Time.deltaTime;

            // ȸ�� �������� ��ü ȸ��
            transform.eulerAngles = new Vector3(0, mx, 0);
        }
    }
}