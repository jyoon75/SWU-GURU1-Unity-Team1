using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActionController : MonoBehaviour
{

//    [SerializeField] 
//    private float range; //Ŭ�� ���� �Ÿ�
//    private bool clickActivated = false; //Ŭ�� ���� �� Ʈ��

//    private RaycastHit hitInfo; //�浹ü ���� ����

//    [SerializeField]
//    private LayerMask layerMask; //ħ�� ���̾�� �����ϵ��� ���̾� ����ũ ����

//    [SerializeField]
//    private Text printText;

//    // Start is called before the first frame update
//    void Start()
//    {
        
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        CheckBed();
//        ClickBed();    }

//    private void ClickBed()
//    {
//        if(Input.GetKeyDown(KeyCode.E))
//        {
//            CheckBed();
//            CanSleep();
//        }
//    }

//    private void CanSleep()
//    {
//        if(hitInfo.transform != null) 
//        {
//            Debug.Log("���ƾ�");
//            BedInfoDisappear();
//        }
//    }
//    private void CheckBed()
//    {
//        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hitInfo, layerMask))
//        {
//            if (hitInfo.transform.tag == "Bed")
//            {
//                BedInfoAppear();
//            }
//        }
//        else
//        {
//            BedInfoDisappear();
//        }
//    }

//    private void BedInfoAppear()
//    {
//        clickActivated = true;
//        printText.gameObject.SetActive(true);
//        printText.text = hitInfo.transform.GetComponent<ClickBed>().bed.bedName + "�ڱ� [EŰ]";
//    }

//    private void BedInfoDisappear()
//    {
//        clickActivated = false;
//    }
}
