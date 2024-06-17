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


    public float findTargetTime;   //Target�� ã�� �ð� �߰�
    // Start is called before the first frame update
    void Start()
    {
        //�ֱ� ���� ������ ���� �ð��� 0���� �ʱ�ȭ
        timeAfterSpawn = 0f;
        //ź�� ���� ������ spawnRateMin�� spawnRateMax ���̿� ���� ����
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);
        //PlayerController ������Ʈ�� 
        target = FindObjectOfType<PlayerController>().transform; //Target�� (Transform) , FindObjectOfType<PlayerController>()(GameObject) �̱� ������
                                                                 //.transform ���� ���� ������ ������ ����� �ش�

        //���� ������Ʈ�� ã�� ���
        //FindObjectOfType : ������Ʈ�� ã�´�.
        //FindWithTag : Tag�� ���� ������Ʈ�� ã�´�. -> GameObject.FindWithTag("Respawn");
    }

    // Update is called once per frame
    void Update()
    {
        if (findTargetTime >= 1.0f)              //Ÿ���� ���� �ð��� 1�ʰ� �Ѿ� ���� ��
        {
            GameObject findTarget = GameObject.FindWithTag("Player");
            if(findTarget != null)
            {
                target = findTarget.transform;
            }

                                               //ã�� �ð��� �ʱ�ȭ �����ش�.
        }
        if(target == null)                   //Ÿ���� ���� ���
        {
            findTargetTime += Time.deltaTime;   //Ÿ���� ���� ��� ���� �ð��� ����ؼ� 
            return;                          //Update�� ����������.
        }    

        timeAfterSpawn += Time.deltaTime;

        if(timeAfterSpawn >= spawnRate)
        {
            timeAfterSpawn = 0f;

            //bulletPrefab�� �������� ����
            //transform.position ��ġ�� transform.rotation ȸ������ ����
            GameObject bullet
                = Instantiate(bulletPrefabs, transform.position, transform.rotation);

            //������ bullet ���� ������Ʈ�� ���� ������ target�� ���ϵ��� ȸ��
            bullet.transform.LookAt(target, Vector3.up);

            //������ ���� ������ spawnRateMin, spawnRateMax ���̿��� ������ ����
            spawnRate = Random.Range(spawnRateMin, spawnRateMax);
        }
    }
}
