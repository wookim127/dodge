using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet: MonoBehaviour
{
    public float speed = 8.0f;         //ź�� �̵� �ӷ�
    private Rigidbody bulletRigidbody;    //�̵��� ����� ������ٵ� ������Ʈ

    // Start is called before the first frame update
    void Start()
    {
        //���� ������Ʈ���� Rigidbody ������Ʈ�� ã�Ƽ� BulletRigidbody�� �Ҵ�
        bulletRigidbody = GetComponent<Rigidbody>();

        //������ٵ��� �ӵ� = ���� ���� * �̵� �ӷ�
        bulletRigidbody.velocity = transform.forward * speed;

        Destroy(gameObject, 3.0f);
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

        }

            PlayerController playerController = other.GetComponent<PlayerController>();
        
        if (playerController != null)
        {
            playerController.Die();
        }
        
    }
}


