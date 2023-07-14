using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    private Vector3 velocity;  //移動方向
    private float moveSpeed = 5.0f;  //移動速度


    //起動時に処理される
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //矢印入力から、XZ平面を移動する方向(velocity)を得る
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

        //速度ベクトルの長さを1秒でmoveSpeedだけ進むように調整
        velocity = velocity.normalized * moveSpeed * Time.deltaTime;

        //いずれかの方向に移動している場合
        if (velocity.magnitude > 0)
        {
            //プレイヤーの位置(transform.position)の更新 
            //移動ベクトル(velocity)を足す
            transform.position += velocity;
        }

    }
}
