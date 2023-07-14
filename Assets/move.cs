using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    private Vector3 velocity;  //�ړ�����
    private float moveSpeed = 5.0f;  //�ړ����x


    //�N�����ɏ��������
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //�����͂���AXZ���ʂ��ړ��������(velocity)�𓾂�
        velocity = Vector3.zero;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            velocity.z += 1;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            velocity.x -= 1;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            velocity.z -= 1;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            velocity.x += 1;
        }

        //���x�x�N�g���̒�����1�b��moveSpeed�����i�ނ悤�ɒ���
        velocity = velocity.normalized * moveSpeed * Time.deltaTime;

        //�����ꂩ�̕����Ɉړ����Ă���ꍇ
        if (velocity.magnitude > 0)
        {
            //�v���C���[�̈ʒu(transform.position)�̍X�V 
            //�ړ��x�N�g��(velocity)�𑫂�
            transform.position += velocity;
        }

    }
}
