using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGenerator : MonoBehaviour
{
    [SerializeField]
    [Tooltip("��������GameObject")]
    private GameObject[] obj;
    [SerializeField]
    [Tooltip("rangeA")]
    private Transform rangeA;
    [SerializeField]
    [Tooltip("rangeB")]
    private Transform rangeB;

    public float interval = 4.0f;

    public int number;
    // float countdown = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObj", 0.1f, interval);
    }

    // Update is called once per frame
    void SpawnObj()
    {
        float x = Random.Range(rangeA.position.x, rangeB.position.x);
        float y = rangeA.position.y;
        float z = rangeA.position.z;

        number = Random.Range(1, 100);

        if (number > 10)
        {
            Instantiate(obj[0], new Vector3(x, y, z), transform.rotation);
        }
        else
        {
            Instantiate(obj[1], new Vector3(x, y, z), transform.rotation); 
        }
    }

    // void Update()
    // {
    //     if(countdown >= 0)
    //     {
    //         countdown -= Time.deltaTime;
    //     }
    //     if(countdown < 0)
    //     {
    //         InvokeRepeating("SpawnObj", 0.1f, interval);
    //     }
    // }
}
