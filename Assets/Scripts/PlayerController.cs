using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//����� Ű���� �Է� ����
//������ٵ� ����Ͽ� Player ���� ������Ʈ �����̰� ����
public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRigidbody;         //�̵��� ����� ������ �ٵ� ������Ʈ
    public float speed = 8.0f;

    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void Update()
    {
        //������� �������� �Է� ���� �����Ͽ� ����
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        //���� �̵� �ӵ��� �Է� ���� �̵� �ӷ��� ����ؼ� ����
        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        //Vector3 �ӵ��� ����
        Vector3 newVelocity = new Vector3(xSpeed, 0.0f, zSpeed);

        //������ٵ��� �ӵ��� �Ҵ�
        playerRigidbody.velocity = newVelocity;
    }


    public void Die()
    {
        // ���� �����ϴ� GameManager Ÿ���� ������Ʈ�� ã�Ƽ� ��������
        GameManager gameManager = FindObjectOfType<GameManager>();


        gameManager.EndGame();

        Destroy(gameObject);
    }
}
