using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public static float countdownSeconds;
    float countdown = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        countdownSeconds = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if(countdown >= 0)
        {
            countdown -= Time.deltaTime;
        }
        if(countdown <= 0)
        {
            countdownSeconds -= Time.deltaTime;
            int t = Mathf.FloorToInt(countdownSeconds);
            Text uiText = GetComponent<Text>();
            uiText.text = "制限時間:" + t;

            if (countdownSeconds <= 0)
            {
                // 0秒になったときの処理
                SceneManager.LoadScene("result");
            }   
        }
    }
}
