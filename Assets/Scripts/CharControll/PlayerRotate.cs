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
            // 마우스 입력 받아 변수에 저장
            float mouse_X = Input.GetAxis("Mouse X");

            // 회전 값 변수에 마우스 입력값 미리 누적
            mx += mouse_X * rotSpeed * Time.deltaTime;

            // 회전 방향으로 물체 회전
            transform.eulerAngles = new Vector3(0, mx, 0);
        }
    }
}