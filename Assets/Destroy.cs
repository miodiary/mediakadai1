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
        // �n�ʂɏՓ˂����玩�I�u�W�F�N�g�폜
        if (collision.gameObject.name == "Stage")
        {
            Destroy(gameObject);
        }

    }
}
