using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameoverText;      //���� ���� �� Ȱ��ȭ�� �ؽ�Ʈ ���� ������Ʈ (TextUI)
    public Text timeText;                //���� �ð��� ǥ���� �ؽ�Ʈ ������Ʈ
    public Text recordText;              //�ְ� ����� ǥ���� �ؽ�Ʈ ������Ʈ

    private float surviveTime;           //���� �ð�
    private bool isGameover;             //���ӿ��� ����

    void Start()
    {

        surviveTime = 0;
        isGameover = false;
    }

    void Update()
    {
        if (!isGameover)
        {

            surviveTime += Time.deltaTime;

            timeText.text = "Time : " + (int)surviveTime;               //float -> int ��ȯ ��Ű�� �Ҽ����� �������� ����
        }
        else
        {
            if(Input.GetKeyDown(KeyCode.R))
            {

                SceneManager.LoadScene("SampleScene");
            }
        }

    }

    public void EndGame()
    {

        isGameover = true;

        gameoverText.SetActive(true);

        float bestTime = PlayerPrefs.GetFloat("BestTime");

        //���� ������ �ְ� ��Ϻ��� ���� ���� �ð��� ��ũ�ٸ�
        if(surviveTime > bestTime)
        {

            bestTime = surviveTime;

            //����� �ְ����� BestTime Ű�� ����
            PlayerPrefs.SetFloat("BestTime", bestTime);
        }


        recordText.text = "Best Time : " + (int)bestTime;
    }

}
