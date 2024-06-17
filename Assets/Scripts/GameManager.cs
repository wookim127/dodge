using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameoverText;      //게임 오버 시 활성화할 텍스트 게임 오브젝트 (TextUI)
    public Text timeText;                //생존 시간을 표시할 텍스트 컴포넌트
    public Text recordText;              //최고 기록을 표시할 텍스트 컴포넌트

    private float surviveTime;           //생존 시간
    private bool isGameover;             //게임오버 상태

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

            timeText.text = "Time : " + (int)surviveTime;               //float -> int 변환 시키면 소수점이 없어져서 보임
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

        //이전 까지의 최고 기록보다 현재 생존 시간이 더크다면
        if(surviveTime > bestTime)
        {

            bestTime = surviveTime;

            //변경된 최고기록을 BestTime 키로 저장
            PlayerPrefs.SetFloat("BestTime", bestTime);
        }


        recordText.text = "Best Time : " + (int)bestTime;
    }

}
