using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoo : MonoBehaviour
{
    Animal[] animals;
    // Start is called before the first frame update
    void Start()
    {
        Animal tom = new Animal();       //Class Animal�� �̸��� tom �̶�� ����
        tom.name = "��";                 //tom ���� ���� Name �� �����ϱ� ���ؼ� Dot(.) ����� name �� ����
        tom.sound = "�Ŀ�!";

        tom.PlaySound();                 //PlaySound���� Debug.Log�� ����Ͽ� name�� sound�� ���

        Animal jerry = new Animal();
        jerry.name = "����";
        jerry.sound = "����!";

        jerry.PlaySound();



        for(int i = 0; i < animals.Length; i++)
        {
            animals[i] = new Animal();
            animals[i].name = i.ToString() + " ��° ����";
            animals[i].sound = i.ToString() + " ��° ���� ���� �Ҹ�";
            animals[i].PlaySound();
        }

        
           
           
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
