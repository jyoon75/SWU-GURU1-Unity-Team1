using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ������Ʈ â���� Ŭ���� �߰��� �� �ֵ���
[CreateAssetMenu(fileName = "New Item", menuName = "New Item/item")]
public class Item : ScriptableObject
{
    public string itemName;         // ������ �̸�
    public Sprite itemImage;        // ������ �̹���
    public GameObject itemPrefab;   // ������ ������
    public ItemType itemType;       // ������ ����

    public enum ItemType
    {
        Used,   // �Ҹ�ǰ
        Quest,
        ETC
    }
}

/*
[System.Serializable]
public class Item
{
    public string itemName;
    public Sprite itemImage;
}

*/