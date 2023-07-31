using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class Slot : MonoBehaviour
{
    public Item item;           // 획득 아이템
    public int itemCount;       // 획득 아이템 개수
    public Image itemImage;     // 획득 아이템 이미지
    public TextMeshProUGUI countText;   // 개수 표시용 텍스트

    // 이미지 투명도 조절
    void SetColor(float alpha)
    {
    Color color = itemImage.color;
    color.a = alpha;
    itemImage.color = color;
    }

    // 아이템 획득
    public void Add(Item _item, int _count = 1)
    {
        item = _item;
        itemCount = _count;
        itemImage.sprite = item.itemImage;

        countText.text = itemCount.ToString();
        SetColor(1);
    }

    // 아이템 개수 조정
    public void SetSlotCount(int _count)
    {
        itemCount += _count;
        countText.text = itemCount.ToString();

        // 만약 아이템 개수가 0보다 작다면 슬롯 비우기
        if (itemCount <= 0)
            ClearSlot();
    }

    // 슬롯 비우기
    private void ClearSlot()
    {
        item = null;
        itemCount = 0;
        itemImage.sprite = null;
        SetColor(0);
        countText.text = "";        
    }
}