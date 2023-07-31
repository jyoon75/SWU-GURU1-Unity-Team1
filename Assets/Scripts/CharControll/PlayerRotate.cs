//���� �ڵ�

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
       Cursor.lockState = CursorLockMode.Locked; // ���콺 Ŀ���� ȭ�� �߾ӿ� ����
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


//���� ���� �ڵ�


// using UnityEngine;

// public class CameraMouseLook : MonoBehaviour
// {
//     public float sensitivity = 5f; // ī�޶� ȸ�� �ӵ�
//     public Transform playerTransform; // �÷��̾��� Transform�� �����ϴ� ����

//     private float rotationX = 0f;
    
//     private void Start()
//     {
//         Cursor.lockState = CursorLockMode.Locked; // ���콺 Ŀ���� ȭ�� �߾ӿ� ����
//     }

//     private void Update()
//     {
//         // ���콺 �Է��� �޾Ƽ� ī�޶� ȸ����ŵ�ϴ�.
//         float mouseX = Input.GetAxis("Mouse X") * sensitivity;
//         float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

//         // ���� ȸ�� (�÷��̾ �������� �¿� ȸ��)
//         playerTransform.Rotate(Vector3.up, mouseX);

//         // ���� ȸ�� (ī�޶� �������� ���� ȸ��)
//         rotationX -= mouseY;
//         rotationX = Mathf.Clamp(rotationX, -90f, 90f); // ī�޶� �ʹ� ȸ������ �ʵ��� ����
//         transform.localRotation = Quaternion.Euler(rotationX, 0f, 0f);
//     }
// }