using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(0, 0, 10);
        transform.localScale = new Vector3(1, 1, 1);


        transform.rotation = Quaternion.Euler(new Vector3(30, 60, 90));


        Quaternion rotation = Quaternion.Euler(new Vector3(0, 60, 0));

        Vector3 eulerRotation = rotation.eulerAngles;

        Quaternion a = Quaternion.Euler(30, 0, 0);
        Quaternion b = Quaternion.Euler(0, 60, 0);

        Quaternion Qrotation = a*b;
    }
}
