using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 7f;    // 이동 속도 변수

    CharacterController cc;         // 캐릭터 콘트롤러 변수

    float gravity = -20f;           // 중력 변수
    float yVelocity = 0;            // 수직 속력 변수

    public float jumpPower = 5.5f;  // 점프력 변수
    public bool isJumping = false;  // 점프 상태 변수

    public int hp = 20;             // 플레이어 체력 변수

    public ActionManager actionManager;

    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        // 사용자의 입력 받기
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // 이동 방향 설정
        Vector3 dir = new Vector3(h, 0, v);
        dir = dir.normalized;

        dir = Camera.main.transform.TransformDirection(dir); // 메인 카메라 기준으로 방향 변환

        // 만약 점프 상태 AND 바닥에 착지
        if (isJumping && cc.collisionFlags == CollisionFlags.Below)
        {
            isJumping = false; // 점프 상태가 아니다로 초기화
            yVelocity = 0;
        }
        //점프
        if (isJumping == false && Input.GetButtonDown("Jump") && actionManager.playerAction == true)
        {
            yVelocity = jumpPower;
            isJumping = true;
        }

        // 캐릭터 수직 속도에 중력 값 적용
        yVelocity += gravity * Time.deltaTime;
        dir.y = yVelocity;

        if (actionManager.playerAction)
        {
            cc.Move(dir * moveSpeed * Time.deltaTime);
        }
    }
}

