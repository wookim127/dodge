using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int gold = 1000;          //int(정수) gold(변수 이름) 선언하고 1000값을 넣어줌
    public float itemWeight = 1.34f; //float (실수) itemWeight(변수 이름) 선언하고 1.34값을 넣어줌
    public bool isStoreOpen = true;  // bool (참/거짓) isStoreOpen (변수이름) 선언하고 true 값을 넣어줌
    public string itemName = "포션"; //string(문자열) itemName(변수 이름) 선언하고 포션(문자열)을 넣어줌

    public int HP = 100;             //체력값 선언
    public float MoveDistance = 0.0f; //이동 값 선언

    public void Move()                  //이동 함수 선언
    {
        HP = HP - 10;                   //함수 hp  인수 받은 만큼 감소
        MoveDistance = MoveDistance + 1; //함수 distance 인수 받은 만큼 이동
    }

    public void Move(int hp, int distance)                  //이동 함수 선언
    {
        HP = HP - hp;                   //체력 10 감소
        MoveDistance = MoveDistance + distance; //이동 위치 1 증가
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
        if(Input.GetKeyDown(KeyCode.Alpha1))      //스페이스 버튼을 눌렀을때 (Input 클래스로 입력감지)
        {
            Debug.Log(KeyCode.Alpha1.ToString() + "버튼 눌림 ");
            Move();                              //Move 함수 사용
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log(KeyCode.Alpha2.ToString() + "버튼 눌림 ");
            Move(30, 1);
        }
        if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            Debug.Log(KeyCode.Alpha3.ToString() + "버튼 눌림 ");
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
