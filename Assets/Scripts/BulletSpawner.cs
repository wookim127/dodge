using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefabs;
    public float spawnRateMin = 0.5f;
    public float spawnRateMax = 3.0f;

    private Transform target;
    private float spawnRate;
    public float timeAfterSpawn;


    public float findTargetTime;   //Target을 찾는 시간 추가
    // Start is called before the first frame update
    void Start()
    {
        //최근 생성 이후의 누적 시간을 0으로 초기화
        timeAfterSpawn = 0f;
        //탄알 생성 간격을 spawnRateMin과 spawnRateMax 사이에 랜덤 지정
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);
        //PlayerController 컴포넌트를 
        target = FindObjectOfType<PlayerController>().transform; //Target은 (Transform) , FindObjectOfType<PlayerController>()(GameObject) 이기 때문에
                                                                 //.transform 으로 같은 형태의 변수로 만들어 준다

        //게임 오브젝트를 찾는 방법
        //FindObjectOfType : 컴포넌트로 찾는다.
        //FindWithTag : Tag로 게임 오브젝트를 찾는다. -> GameObject.FindWithTag("Respawn");
    }

    // Update is called once per frame
    void Update()
    {
        if (findTargetTime >= 1.0f)              //타겟이 없는 시간이 1초가 넘어 갔을 떄
        {
            GameObject findTarget = GameObject.FindWithTag("Player");
            if(findTarget != null)
            {
                target = findTarget.transform;
            }

                                               //찾는 시간을 초기화 시켜준다.
        }
        if(target == null)                   //타겟이 없을 경우
        {
            findTargetTime += Time.deltaTime;   //타겟이 없을 경우 누적 시간을 계산해서 
            return;                          //Update를 빠져나간다.
        }    

        timeAfterSpawn += Time.deltaTime;

        if(timeAfterSpawn >= spawnRate)
        {
            timeAfterSpawn = 0f;

            //bulletPrefab의 복제본을 생성
            //transform.position 위치와 transform.rotation 회전으로 생성
            GameObject bullet
                = Instantiate(bulletPrefabs, transform.position, transform.rotation);

            //생성된 bullet 게임 오브젝트의 정면 방향이 target을 향하도록 회전
            bullet.transform.LookAt(target, Vector3.up);

            //다음번 생성 간격을 spawnRateMin, spawnRateMax 사이에서 랜덤을 지정
            spawnRate = Random.Range(spawnRateMin, spawnRateMax);
        }
    }
}
