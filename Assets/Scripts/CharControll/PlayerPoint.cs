using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerPoint : MonoBehaviour
{
    public Image crossImg;                  // ũ�ν� �̹���
    public TextMeshProUGUI contactText;     // ũ�ν� �� �ؽ�Ʈ
    public TextMeshProUGUI messageText;     // �޽��� �ؽ�Ʈ

    public TalkManager talkManager;
    public Inventory inventory;
    public DayNightController dayNightController;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!dayNightController.isNight) // ���� ���� ��ȣ�ۿ� ����
        {
            CheakObject();
        }
    }


    void CheakObject()
    {
        // ���� ���� �� �߻� ��ġ�� ������� ����
        Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
        RaycastHit hitInfo = new RaycastHit();  // ���̰� �ε��� ����� ���� ����

        // ���� �߻� �� ���� �ε��� ��ü �ִٸ�
        if (Physics.Raycast(ray, out hitInfo))
        {
            // ���� ���̿� �ε��� ����� ���̾ 'Character'���
            if (hitInfo.transform.gameObject.layer == LayerMask.NameToLayer("Character"))
            {
               









            }

            // ���� ���̿� �ε��� ����� ���̾ 'Item'���
            else if (hitInfo.transform.gameObject.layer == LayerMask.NameToLayer("Item"))
            {
                // ũ�ν� ��������� ����� 'Ŭ���Ͽ� ���' ���� ����
                crossImg.color = Color.yellow;
                contactText.text = "Click to get";

                // ���� ���콺 ���� ��ư �Է¹���
                if (Input.GetMouseButtonDown(0))
                {
                    // �ε��� ����� ������ ������ �κ��丮�� �߰�
                    Item targetItem = hitInfo.transform.GetComponent<ItemData>().item;
                    inventory.AcquireItem(targetItem);

                    // ȹ�� �޽��� ����
                    messageText.text = targetItem.itemName + " ȹ��";
                    StartCoroutine(ClearMessage());

                    // ȹ���� ������ ���ֱ�
                    Destroy(hitInfo.transform.gameObject);
                    targetItem = null;
                }
            }

            // ���� �ε��� ����� �ױװ� Bed���
            else if(hitInfo.collider.CompareTag("Bed"))
            {
                // ũ�ν� ��������� ����� 'Ŭ���Ͽ� �޽��ϱ�' ���� ����
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