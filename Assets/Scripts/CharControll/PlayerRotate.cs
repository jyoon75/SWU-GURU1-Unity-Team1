////원본 코드

//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class PlayerRotate : MonoBehaviour
//{
//    public float rotSpeed = 200f;

//    float mx = 0;

//    public ActionManager actionManager;

//    // Start is called before the first frame update
//    void Start()
//    {
//        Cursor.lockState = CursorLockMode.Locked; // 마우스 커서를 화면 중앙에 고정
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        if (actionManager.playerAction)
//        {
//            // 마우스 입력 받아 변수에 저장
//            float mouse_X = Input.GetAxis("Mouse X");

//            // 회전 값 변수에 마우스 입력값 미리 누적
//            mx += mouse_X * rotSpeed * Time.deltaTime;

//            // 회전 방향으로 물체 회전
//            transform.eulerAngles = new Vector3(0, mx, 0);
//        }
//    }
//}


//이하 수정 코드


using UnityEngine;

public class CameraMouseLook : MonoBehaviour
{
    public float sensitivity = 5f; // 카메라 회전 속도
    public Transform playerTransform; // 플레이어의 Transform을 저장하는 변수

    private float rotationX = 0f;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // 마우스 커서를 화면 중앙에 고정
    }

    private void Update()
    {
        // 마우스 입력을 받아서 카메라를 회전시킵니다.
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        // 수평 회전 (플레이어를 기준으로 좌우 회전)
        playerTransform.Rotate(Vector3.up, mouseX);

        // 수직 회전 (카메라를 기준으로 상하 회전)
        rotationX -= mouseY;
        rotationX = Mathf.Clamp(rotationX, -90f, 90f); // 카메라가 너무 회전하지 않도록 제한
        transform.localRotation = Quaternion.Euler(rotationX, 0f, 0f);
    }
}