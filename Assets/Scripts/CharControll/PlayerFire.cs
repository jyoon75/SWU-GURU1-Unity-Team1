using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    //public GameObject bulletEffect; // 피격 이펙트 오브젝트
    //ParticleSystem ps;              // 피격 이펙트 파티클 시스템

    public int weaponPower = 5;     // 발사 무기 공격력
    public int attackPower = 7;     // 근거리 공격력
    public float attackRadius = 2.0f;   // 근거리 공격 반경

    public DayNightController dayNightController;

    enum WeaponMode                 // 무기 모드 변수
    {
        Shotgun,
        Bat
    }
    WeaponMode wMode;

    //public Text wModeText;          // 무기 모드 텍스트
    //public GameObject[] eff_Flash;  // 총 발사 효과 오브젝트 배열


    // Start is called before the first frame update
    void Start()
    {
        // 피격 이펙트 오브젝트에서 파티클 시스템 컴포넌트 가져오기
        //ps = bulletEffect.GetComponent<ParticleSystem>();

        // 애니메이터 컴포넌트 가져오기
        //anim = GetComponentInChildren<Animator>();

        // 무기 기본 모드를 노멀 모드로 설정한다.
        wMode = WeaponMode.Shotgun;
    }

    // Update is called once per frame
    void Update()
    {
        // 게임 상태가 '밤'일 때만 조작할 수 있음
        if (dayNightController.isNight) // 현재 테스트를 위에 낮으로만 서정되어 있음
        {
            return;
        }

        // 만약 마우스 왼쪽 버튼 입력받음
        if (Input.GetMouseButtonDown(0))
        {
            switch (wMode)
            {
                case WeaponMode.Shotgun:

                    Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
                    RaycastHit hitInfo = new RaycastHit();

                    // 레이 발사 후 만약 부딪힌 물체 있다면
                    if (Physics.Raycast(ray, out hitInfo))
                    {
                        // 만약 레이에 부딪힌 대상의 레이어가 'Enemy'라면 데미지 함수 실행
                        if (hitInfo.transform.gameObject.layer == LayerMask.NameToLayer("Enemy"))
                        {
                            //EnemyFSM eFSM = hitInfo.transform.GetComponent<EnemyFSM>();
                            //eFSM.HitEnemy(weaponPower);
                        }
                        else // 그렇지 않다면 피격 이벤트 표시
                        {
                            print("탕!");
                            // 피격 이벤트 위치 레이 부딪힌 지점으로
                            //bulletEffect.transform.position = hitInfo.point;

                            // 피격 이벤트의 forward 방향을 레이가 부딪힌 지점의 법선 벡터와 일치시킴
                            //bulletEffect.transform.forward = hitInfo.normal;

                            // 피격 이벤트 플레이
                            //ps.Play();
                        }
                        // 총 이펙트를 실시
                        //StartCoroutine(ShootEffectOn(0.05f));
                    }
                    break;

                case WeaponMode.Bat:
                    //Collider[] cols = Physics.OverlapBox(transform.position + new Vector3(0f, 0f, 2f), new Vector3(4, 2, 3), transform.rotation, LayerMask.NameToLayer("Enemy"));
                    Collider[] cols = Physics.OverlapSphere(transform.position, attackRadius, LayerMask.NameToLayer("Enemy"));
                    //OnDrawGizmos();

                    for (int i = 0; i < cols.Length; i++)
                    {
                        print(i + "에너미 데미지");
                        cols[i] = null;
                    }


                    break;
            }
        }

        // 만약 숫자 1 입력 받으면 무기 모드 일반 모드로 변경
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            wMode = WeaponMode.Shotgun;
            //wModeText.text = "Normal Mode";
        }
        // 만약 숫자 2 입력 받으면 무기 모드 스나이퍼 모드로 변경
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            wMode = WeaponMode.Bat;
            //wModeText.text = "Sniper Mode";
        }
    }
    /*
    // 총구 이펙트 코루틴 함수
    IEnumerator ShootEffectOn(float duration)
    {
        // 랜덤하게 숫자 뽑기
        int num = Random.Range(0, eff_Flash.Length - 1);
        // 이펙트 오브젝트 배열에서 뽑힌 숫자에 해당하는 이펙트 오브젝트 활성화
        eff_Flash[num].SetActive(true);
        // 지정한 시간만큼 기다림
        yield return new WaitForSeconds(duration);
        // 이펙트 오브젝트를 다시 비활성화
        eff_Flash[num].SetActive(false);
    }
    */
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position + new Vector3(0f, 0f, 2f), attackRadius);
    }
}
