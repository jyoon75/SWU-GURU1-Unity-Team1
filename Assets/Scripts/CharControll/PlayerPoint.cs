using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerPoint : MonoBehaviour
{
    public Image crossImg; // 크로스 이미지
    public TextMeshProUGUI contactText; // 크로스 옆 텍스트
    public TextMeshProUGUI messageText; // 메시지 텍스트

    public TalkManager talkManager;
    public Inventory inventory;
    public DayNightController dayNightController;
    public PlayerMove playerMove;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!dayNightController.isNight)
        {
            CheakObject();
        }
    }


    void CheakObject()
    {
        Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
        RaycastHit hitInfo = new RaycastHit();

        // 레이 발사 후 만약 부딪힌 물체 있다면
        if (Physics.Raycast(ray, out hitInfo))
        {
            // 만약 레이에 부딪힌 대상의 레이어가 'Character'라면
            if (hitInfo.transform.gameObject.layer == LayerMask.NameToLayer("Character"))
            {
               
            }

            // 만약 레이에 부딪힌 대상의 레이어가 'Item'라면
            else if (hitInfo.transform.gameObject.layer == LayerMask.NameToLayer("Item"))
            {
                // 크로스 노란색으로 만들고 '클릭하여 얻기' 문구 띄우기
                crossImg.color = Color.yellow;
                contactText.text = "Click to get";

                // 만약 마우스 왼쪽 버튼 입력받음
                if (Input.GetMouseButtonDown(0))
                {
                    Item targetItem = hitInfo.transform.GetComponent<ItemData>().item;

                    if (targetItem.itemName == "Can" && playerMove.cur_hp < playerMove.max_hp)
                    {
                        // 체력 회복
                        playerMove.cur_hp += 50;
                        if (playerMove.cur_hp > playerMove.max_hp)
                            playerMove.cur_hp = playerMove.max_hp;
                        // 회복 메시지 띄우기
                        messageText.text = "체력 +50";
                        StartCoroutine(ClearMessage());
                    }
                    else if (targetItem.itemName == "Flask" && playerMove.cur_ts < playerMove.max_ts)
                    {
                        // 갈증 회복
                        playerMove.cur_ts += 50;
                        if (playerMove.cur_ts > playerMove.max_ts)
                            playerMove.cur_ts = playerMove.max_ts;
                        // 메시지 띄우기
                        messageText.text = "수분 +50";
                        StartCoroutine(ClearMessage());
                    }
                    else
                    {
                        // 부딪힌 대상의 아이템 정보를 인벤토리에 추가
                        inventory.AcquireItem(targetItem);

                        // 획득 메시지 띄우기
                        messageText.text = targetItem.itemName + " 획득";
                        StartCoroutine(ClearMessage());
                    }
                    // 획득한 아이템 없애기
                    Destroy(hitInfo.transform.gameObject);
                    targetItem = null;
                }
            }

            // 만약 레이에 부딪힌 대상의 테그가 'Bed'라면
            else if (hitInfo.collider.CompareTag("Bed"))
            {
                // 크로스 노란색으로 만들고 '클릭하여 쉬기' 문구 띄우기
                crossImg.color = Color.yellow;
                contactText.text = "Click to rest";

                if (Input.GetMouseButtonDown(0))
                {
                    crossImg.color = Color.white;
                    contactText.text = " ";
                    dayNightController.ToggleDayNight();
                }
            }

            else
            {
                crossImg.color = Color.white;
                contactText.text = " ";
            }
        }
    }

    IEnumerator ClearMessage()
    {
        yield return new WaitForSeconds(1.0f);
        messageText.text = " ";
    }
}