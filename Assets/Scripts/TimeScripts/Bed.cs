using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bed : MonoBehaviour
{
    public DayNightController dayNightController;
    public LayerMask objectLayerMask;
    public float range = 3f;

    //private void OnMouseDown()
    //{

    //    if (dayNightController != null)
    //    {
    //        // 클릭 시 낮과 밤을 토글합니다.
    //        dayNightController.ToggleDayNight();
    //    }
    //}

    ////public GameObject cube;

    ////private void OnMouseDown()
    ////{
    ////    Debug.Log("출력할 대사...");
    ////    Destroy(cube);
    ////    //TurnToNight();
    ////}

    //public Light sunLight;

    //private bool isNight = false;

    //private void TurnToNight()
    //{

    //}
    //// Start is called before the first frame update
    //void Start()
    //{

    //}

    //// Update is called once per frame
    void Update()
    {
            if(Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if(Physics.Raycast(ray, out hit, range, objectLayerMask))
                {
                    if(hit.collider.CompareTag("Bed"))
                    {
                        Debug.Log("출력할 대사...");
                        dayNightController.ToggleDayNight();

                    }
                }
            }
        
    }
}
