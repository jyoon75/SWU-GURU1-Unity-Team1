using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public GameObject InventoryPanel;   // �κ��丮 â
    bool activeInven = false;           // �κ��丮 Ȱ��ȭ ����
    public GameObject SlotHolder;       // ���� ����ִ� ����

    public Slot[] slots;                // ���� ���� ����

    // Start is called before the first frame update
    void Start()
    {
        // ���� ���� ������ ���Ե� ä���
        slots = SlotHolder.GetComponentsInChildren<Slot>();
    }

    // Update is called once per frame
    void Update()
    {
        // ���� E�� �����ٸ� �κ��丮 Ȱ��ȭ ���� ��ȯ�ϱ�
        if (Input.GetKeyDown(KeyCode.E))
        {
            activeInven = !activeInven;
            InventoryPanel.SetActive(activeInven);
        }
    }

    public void AcquireItem(Item _item, int _count = 1)
    {
        // ��ĭ�� �ƴ� ���� �� ��ġ�� �������� �ִٸ� ���� ���ϱ�
        for (int i = 0; i < slots.Length; i++)
        {
            if (slots[i].item != null)
            {
                if (slots[i].item.itemName == _item.itemName)
                {
                    slots[i].SetSlotCount(_count);
                    return;
                }
            }
        }
        // �� ���Կ� ������ ä���
        for (int i = 0; i < slots.Length; i++)
        {
            if (slots[i].item == null)
            {
                slots[i].Add(_item, _count);
                return;
            }
        }
    }
}
