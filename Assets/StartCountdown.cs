using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartCountdown : MonoBehaviour
{
    float countdown = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        int n = Mathf.FloorToInt(countdown);
        Text uiText = GetComponent<Text>();
        uiText.text = n;
    }
}
