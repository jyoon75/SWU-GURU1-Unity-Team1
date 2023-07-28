using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public GameObject InventoryPanel;   // 인벤토리 창
    bool activeInven = false;           // 인벤토리 활성화 여부
    public GameObject SlotHolder;       // 슬롯 들어있는 공간

    public Slot[] slots;                // 슬롯 모음 변수

    // Start is called before the first frame update
    void Start()
    {
        // 슬롯 모음 변수에 슬롯들 채우기
        slots = SlotHolder.GetComponentsInChildren<Slot>();
    }

    // Update is called once per frame
    void Update()
    {
        // 만약 E를 눌렀다면 인벤토리 활성화 상태 전환하기
        if (Input.GetKeyDown(KeyCode.E))
        {
            activeInven = !activeInven;
            InventoryPanel.SetActive(activeInven);
        }
    }

    public void AcquireItem(Item _item, int _count = 1)
    {
        // 빈칸이 아닌 슬롯 중 겹치는 아이템이 있다면 숫자 더하기
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
        // 빈 슬롯에 아이템 채우기
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
