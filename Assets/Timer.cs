using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public static float countdownSeconds;

    // Start is called before the first frame update
    void Start()
    {
        countdownSeconds = 50;
    }

    // Update is called once per frame
    void Update()
    {
        countdownSeconds -= Time.deltaTime;
        int t = Mathf.FloorToInt(countdownSeconds);
        Text uiText = GetComponent<Text>();
        uiText.text = "�c�莞��:" + t;

        if (countdownSeconds <= 0)
        {
            // 0�b�ɂȂ����Ƃ��̏���
            SceneManager.LoadScene("result");
        }
    }
}
