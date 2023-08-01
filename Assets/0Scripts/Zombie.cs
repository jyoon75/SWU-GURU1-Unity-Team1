using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public GameObject[] prefabs; 
    private BoxCollider area;    
    public int count = 100;
  
    public GameObject enemy;
    private List<GameObject> gameObject = new List<GameObject>();
    
    void Start()
    {
        area = GetComponent<BoxCollider>();
        
        for(int i = 0; i < count; ++i)//count 수 만큼 생성한다
        {
            Spawn();//생성 + 스폰위치를 포함하는 함수
        }
        
        area.enabled = false;
    }
    private Vector3 GetRandomPosition()
    {
        Vector3 basePosition = transform.position;
        Vector3 size = area.size;
        
        float posX = basePosition.x + Random.Range(-size.x/2f, size.x/2f);
        float posY = basePosition.y + Random.Range(-size.y/2f, size.y/2f);
        float posZ = basePosition.z + Random.Range(-size.z/2f, size.z/2f);
        
        Vector3 spawnPos = new Vector3(posX, posY, posZ);
        
        return spawnPos;
    }
    
    private void Spawn()
    {
        int selection = Random.Range(0, prefabs.Length);
        
        GameObject selectedPrefab = prefabs[selection];
        
        Vector3 spawnPos = GetRandomPosition();//랜덤위치함수
        
        GameObject instance = Instantiate(selectedPrefab, spawnPos, Quaternion.identity);
        gameObject.Add(instance);
    }
    
    
   

    // Update is called once per frame
    void Update()
    {
        if(DayNightController.instance.isNight)
        {
            enemy.SetActive(true); //여긴 활성화
        }
        else
        {
            //여기에 좀비 비활성화
            enemy.SetActive(false);
        }
    }
}
