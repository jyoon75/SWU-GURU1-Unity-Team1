using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class Slot : MonoBehaviour
{
    public Item item;           // ȹ�� ������
    public int itemCount;       // ȹ�� ������ ����
    public Image itemImage;     // ȹ�� ������ �̹���
    public TextMeshProUGUI countText;   // ���� ǥ�ÿ� �ؽ�Ʈ

    // �̹��� ���� ����
    void SetColor(float alpha)
    {
    Color color = itemImage.color;
    color.a = alpha;
    itemImage.color = color;
    }

    // ������ ȹ��
    public void Add(Item _item, int _count = 1)
    {
        item = _item;
        itemCount = _count;
        itemImage.sprite = item.itemImage;

        countText.text = itemCount.ToString();
        SetColor(1);
    }

    // ������ ���� ����
    public void SetSlotCount(int _count)
    {
        itemCount += _count;
        countText.text = itemCount.ToString();

        // ���� ������ ������ 0���� �۴ٸ� ���� ����
        if (itemCount <= 0)
            ClearSlot();
    }

    // ���� ����
    private void ClearSlot()
    {
        item = null;
        itemCount = 0;
        itemImage.sprite = null;
        SetColor(0);
        countText.text = "";        
    }
}