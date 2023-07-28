using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActionController : MonoBehaviour
{

//    [SerializeField] 
//    private float range; //클릭 가능 거리
//    private bool clickActivated = false; //클릭 가능 시 트루

//    private RaycastHit hitInfo; //충돌체 정보 저장

//    [SerializeField]
//    private LayerMask layerMask; //침대 레이어에만 반응하도록 레이어 마스크 설정

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
//            Debug.Log("으아앙");
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
//        printText.text = hitInfo.transform.GetComponent<ClickBed>().bed.bedName + "자기 [E키]";
//    }

//    private void BedInfoDisappear()
//    {
//        clickActivated = false;
//    }
}
