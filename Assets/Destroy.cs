using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        // 地面に衝突したら自オブジェクト削除
        if (collision.gameObject.name == "Stage")
        {
            Destroy(gameObject);
        }

    }
}
