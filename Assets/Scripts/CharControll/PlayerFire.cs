using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    //public GameObject bulletEffect; // �ǰ� ����Ʈ ������Ʈ
    //ParticleSystem ps;              // �ǰ� ����Ʈ ��ƼŬ �ý���

    public int weaponPower = 5;     // �߻� ���� ���ݷ�
    public int attackPower = 7;     // �ٰŸ� ���ݷ�
    public float attackRadius = 2.0f;   // �ٰŸ� ���� �ݰ�

    public DayNightController dayNightController;

    enum WeaponMode                 // ���� ��� ����
    {
        Shotgun,
        Bat
    }
    WeaponMode wMode;

    //public Text wModeText;          // ���� ��� �ؽ�Ʈ
    //public GameObject[] eff_Flash;  // �� �߻� ȿ�� ������Ʈ �迭


    // Start is called before the first frame update
    void Start()
    {
        // �ǰ� ����Ʈ ������Ʈ���� ��ƼŬ �ý��� ������Ʈ ��������
        //ps = bulletEffect.GetComponent<ParticleSystem>();

        // �ִϸ����� ������Ʈ ��������
        //anim = GetComponentInChildren<Animator>();

        // ���� �⺻ ��带 ��� ���� �����Ѵ�.
        wMode = WeaponMode.Shotgun;
    }

    // Update is called once per frame
    void Update()
    {
        // ���� ���°� '��'�� ���� ������ �� ����
        if (dayNightController.isNight) // ���� �׽�Ʈ�� ���� �����θ� �����Ǿ� ����
        {
            return;
        }

        // ���� ���콺 ���� ��ư �Է¹���
        if (Input.GetMouseButtonDown(0))
        {
            switch (wMode)
            {
                case WeaponMode.Shotgun:

                    Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
                    RaycastHit hitInfo = new RaycastHit();

                    // ���� �߻� �� ���� �ε��� ��ü �ִٸ�
                    if (Physics.Raycast(ray, out hitInfo))
                    {
                        // ���� ���̿� �ε��� ����� ���̾ 'Enemy'��� ������ �Լ� ����
                        if (hitInfo.transform.gameObject.layer == LayerMask.NameToLayer("Enemy"))
                        {
                            //EnemyFSM eFSM = hitInfo.transform.GetComponent<EnemyFSM>();
                            //eFSM.HitEnemy(weaponPower);
                        }
                        else // �׷��� �ʴٸ� �ǰ� �̺�Ʈ ǥ��
                        {
                            print("��!");
                            // �ǰ� �̺�Ʈ ��ġ ���� �ε��� ��������
                            //bulletEffect.transform.position = hitInfo.point;

                            // �ǰ� �̺�Ʈ�� forward ������ ���̰� �ε��� ������ ���� ���Ϳ� ��ġ��Ŵ
                            //bulletEffect.transform.forward = hitInfo.normal;

                            // �ǰ� �̺�Ʈ �÷���
                            //ps.Play();
                        }
                        // �� ����Ʈ�� �ǽ�
                        //StartCoroutine(ShootEffectOn(0.05f));
                    }
                    break;

                case WeaponMode.Bat:
                    //Collider[] cols = Physics.OverlapBox(transform.position + new Vector3(0f, 0f, 2f), new Vector3(4, 2, 3), transform.rotation, LayerMask.NameToLayer("Enemy"));
                    Collider[] cols = Physics.OverlapSphere(transform.position, attackRadius, LayerMask.NameToLayer("Enemy"));
                    //OnDrawGizmos();

                    for (int i = 0; i < cols.Length; i++)
                    {
                        print(i + "���ʹ� ������");
                        cols[i] = null;
                    }


                    break;
            }
        }

        // ���� ���� 1 �Է� ������ ���� ��� �Ϲ� ���� ����
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            wMode = WeaponMode.Shotgun;
            //wModeText.text = "Normal Mode";
        }
        // ���� ���� 2 �Է� ������ ���� ��� �������� ���� ����
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            wMode = WeaponMode.Bat;
            //wModeText.text = "Sniper Mode";
        }
    }
    /*
    // �ѱ� ����Ʈ �ڷ�ƾ �Լ�
    IEnumerator ShootEffectOn(float duration)
    {
        // �����ϰ� ���� �̱�
        int num = Random.Range(0, eff_Flash.Length - 1);
        // ����Ʈ ������Ʈ �迭���� ���� ���ڿ� �ش��ϴ� ����Ʈ ������Ʈ Ȱ��ȭ
        eff_Flash[num].SetActive(true);
        // ������ �ð���ŭ ��ٸ�
        yield return new WaitForSeconds(duration);
        // ����Ʈ ������Ʈ�� �ٽ� ��Ȱ��ȭ
        eff_Flash[num].SetActive(false);
    }
    */
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position + new Vector3(0f, 0f, 2f), attackRadius);
    }
}
