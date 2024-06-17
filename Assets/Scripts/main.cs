using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int gold = 1000;          //int(����) gold(���� �̸�) �����ϰ� 1000���� �־���
    public float itemWeight = 1.34f; //float (�Ǽ�) itemWeight(���� �̸�) �����ϰ� 1.34���� �־���
    public bool isStoreOpen = true;  // bool (��/����) isStoreOpen (�����̸�) �����ϰ� true ���� �־���
    public string itemName = "����"; //string(���ڿ�) itemName(���� �̸�) �����ϰ� ����(���ڿ�)�� �־���

    public int HP = 100;             //ü�°� ����
    public float MoveDistance = 0.0f; //�̵� �� ����

    public void Move()                  //�̵� �Լ� ����
    {
        HP = HP - 10;                   //�Լ� hp  �μ� ���� ��ŭ ����
        MoveDistance = MoveDistance + 1; //�Լ� distance �μ� ���� ��ŭ �̵�
    }

    public void Move(int hp, int distance)                  //�̵� �Լ� ����
    {
        HP = HP - hp;                   //ü�� 10 ����
        MoveDistance = MoveDistance + distance; //�̵� ��ġ 1 ����
    }

    public int RandomNumber()
    {
        int Number = 0;
        Number = Random.Range(0, 10);

        return Number;
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Gold : " + gold + "itemWeight : " + itemWeight
            + " isStoreOpen : " + isStoreOpen + " itemName : " + itemName);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))      //�����̽� ��ư�� �������� (Input Ŭ������ �Է°���)
        {
            Debug.Log(KeyCode.Alpha1.ToString() + "��ư ���� ");
            Move();                              //Move �Լ� ���
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log(KeyCode.Alpha2.ToString() + "��ư ���� ");
            Move(30, 1);
        }
        if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            Debug.Log(KeyCode.Alpha3.ToString() + "��ư ���� ");
            Move(15, 2);
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            int GetRandNumber = 0;
            GetRandNumber = RandomNumber();
            Debug.Log(" GetRandNumber  : " + GetRandNumber);

        }
    }
}
