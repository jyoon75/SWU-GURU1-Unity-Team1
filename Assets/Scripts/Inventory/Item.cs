using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 프로젝트 창에서 클래스 추가할 수 있도록
[CreateAssetMenu(fileName = "New Item", menuName = "New Item/item")]
public class Item : ScriptableObject
{
    public string itemName;         // 아이템 이름
    public Sprite itemImage;        // 아이템 이미지
    public GameObject itemPrefab;   // 아이템 프리펩
    public ItemType itemType;       // 아이템 유형

    public enum ItemType
    {
        Used,   // 소모품
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