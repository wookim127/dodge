using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayCode : MonoBehaviour
{
    public int[] students = new int[5];
    // Start is called before the first frame update
    void Start()
    {
        students[0] = 100;
        students[1] = 90;
        students[2] = 80;
        students[3] = 70;
        students[4] = 60;

        //Debug.Log("0 �� �л��� ���� : " + students[0]);
        //Debug.Log("1 �� �л��� ���� : " + students[1]);
        //Debug.Log("2 �� �л��� ���� : " + students[2]);
        //Debug.Log("3 �� �л��� ���� : " + students[3]);
        //Debug.Log("4 �� �л��� ���� : " + students[4]);


        Debug.Log(" students.Length : " + students.Length);

        for (int i = 0; i < students.Length; i++)
        {
            Debug.Log((i + 1) + " �� �л��� ���� : " + students[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
      students[0] = 100;
      students[1] = 90;

    }
}
