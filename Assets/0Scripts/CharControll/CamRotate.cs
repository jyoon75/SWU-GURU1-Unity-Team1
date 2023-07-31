using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRotate : MonoBehaviour
{
    public float rotSpeed = 200f; // 회전 속도 변수

    // 회전 값 변수
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
            // 마우스 입력 받아 변수에 저장
            float mouse_X = Input.GetAxis("Mouse X");
            float mouse_Y = Input.GetAxis("Mouse Y");

            // 회전 값 변수에 마우스 입력값 미리 누적
            mx += mouse_X * rotSpeed * Time.deltaTime;
            my += mouse_Y * rotSpeed * Time.deltaTime;

            // 마우스 상하 이동 회전 변수의 값 -90도 ~ 90도 사이로 제한
            my = Mathf.Clamp(my, -90f, 90f);
            // 회전 방향으로 물체 회전
            transform.eulerAngles = new Vector3(-my, mx, 0);
        }
    }
}
