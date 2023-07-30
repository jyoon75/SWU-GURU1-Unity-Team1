using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public static PlayerMove instance;
    void Awake()
    {
        PlayerMove.instance = this;

    }

    public float moveSpeed = 7f;    // �̵� �ӵ� ����

    CharacterController cc;         // ĳ���� ��Ʈ�ѷ� ����

    float gravity = -20f;           // �߷� ����
    float yVelocity = 0;            // ���� �ӷ� ����

    public float jumpPower = 5.5f;  // ������ ����
    public bool isJumping = false;  // ���� ���� ����

    public int hp = 20;             // �÷��̾� ü�� ����

    public ActionManager actionManager;

    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        // ������� �Է� �ޱ�
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // �̵� ���� ����
        Vector3 dir = new Vector3(h, 0, v);
        dir = dir.normalized;

        dir = Camera.main.transform.TransformDirection(dir); // ���� ī�޶� �������� ���� ��ȯ

        // ���� ���� ���� AND �ٴڿ� ����
        if (isJumping && cc.collisionFlags == CollisionFlags.Below)
        {
            isJumping = false; // ���� ���°� �ƴϴٷ� �ʱ�ȭ
            yVelocity = 0;
        }
        //����
        if (isJumping == false && Input.GetButtonDown("Jump") && actionManager.playerAction == true)
        {
            yVelocity = jumpPower;
            isJumping = true;
        }

        // ĳ���� ���� �ӵ��� �߷� �� ����
        yVelocity += gravity * Time.deltaTime;
        dir.y = yVelocity;

        if (actionManager.playerAction)
        {
            cc.Move(dir * moveSpeed * Time.deltaTime);
        }
        //if(Camera.main !=null) 
        //{
        //    dir = Camera.main.transform.TransformDirection(dir);
        //    transform.position += dir * moveSpeed* Time.deltaTime;
        //    yVelocity += gravity * Time.deltaTime;
        //    dir.y = yVelocity;

        //    cc.Move(dir*moveSpeed*Time.deltaTime);
        
        //}
    }
}

